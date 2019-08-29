using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDArchiver
{
    public partial class frmMain : Form
    {
        FolderBrowserDialog _folderBrowserDialog = new FolderBrowserDialog();

        public frmMain()
        {
            InitializeComponent();

            SetupGridColums(grdFiles);

            txtScannedBy.Text = Properties.Settings.Default.LastScannedBy;
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var selectedFolder = Properties.Settings.Default.LastPathOpened;
            resetMetadata();

            if (selectedFolder != null && selectedFolder != "") {
                _folderBrowserDialog.SelectedPath = selectedFolder;
            }
            if (_folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
            {
                Cursor.Current = Cursors.Default;
                return;
            }
            selectedFolder = _folderBrowserDialog.SelectedPath;

            Properties.Settings.Default.LastPathOpened = selectedFolder;
            Properties.Settings.Default.Save();

            var fileList = ScanFilesForFolder(selectedFolder);
            var fileDetailList = GetDetailsForFiles(fileList);

            grdFiles.DataSource = fileDetailList;

            Cursor.Current = Cursors.Default;
        }

        private void resetMetadata()
        {
            txtCDId.Text = "<Enter Id>";
            txtScanDate.Text = DateTime.Now.ToString();
            txtScanDate.Tag = DateTime.Now; 
            txtNotes.Text = "";
        }

        private List<FileDetail> GetDetailsForFiles(string[] fileList)
        {
            List<FileDetail> results = new List<FileDetail>();

            foreach (var file in fileList)
            {
                FileInfo fi = new FileInfo(file);
                FileDetail fd = new FileDetail();
                fd.Name = fi.Name;
                fd.FullPath = GetPathWithoutDriveName(file, fi);
                fd.Size = fi.Length;
                fd.CreateDate = fi.CreationTime;

                results.Add(fd);
            }

            return results;
        }

        private string GetPathWithoutDriveName(string file, FileInfo fi)
        {
            var driveLetter = Path.GetPathRoot(file);
            return fi.FullName.Substring(driveLetter.Length);
        }

        private string[] ScanFilesForFolder(string selectedFolder)
        {
            return Directory.GetFiles(selectedFolder, "*.*", SearchOption.AllDirectories);
        }

        private void SetupGridColums(DataGridView grid)
        {
            grid.RowHeadersWidth = 15;

            grid.ColumnCount = 4;

            grid.Columns[0].HeaderText = "File Name";
            grid.Columns[0].Width = 120;
            grid.Columns[0].DataPropertyName = "Name";

            grid.Columns[1].HeaderText = "Size";
            grid.Columns[1].Width = 60;
            grid.Columns[1].DataPropertyName = "Size";

            grid.Columns[2].HeaderText = "Create Date";
            grid.Columns[2].DataPropertyName = "CreateDate";

            grid.Columns[3].HeaderText = "Path";
            grid.Columns[3].Width = 500;
            grid.Columns[3].DataPropertyName = "FullPath";
        }

        private void BtnCdIdGen_Click(object sender, EventArgs e)
        {
            txtCDId.Text = "CD" + DateTime.Now.ToString("yyyyMMdd-hhmm");
        }

        private void TxtScannedBy_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastScannedBy = txtScannedBy.Text;
            Properties.Settings.Default.Save();
        }

        private void BtnAddToDb_Click(object sender, EventArgs e)
        {
            var cdDetails = GetCdDetails();
            if (!cdDetails.LooksOk())
            {
                MessageBox.Show("Missing CD Details", "Couldn't add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<FileDetail> fileDetails = (List<FileDetail>)grdFiles.DataSource;
            if (fileDetails == null || fileDetails.Count == 0)
            {
                MessageBox.Show("No Files To Add", "Couldn't add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            SaveCdContentsToDb(cdDetails, fileDetails);

            Cursor.Current = Cursors.Default;
        }

        const string CD_DETAILS_INSERT = "INSERT CdDetails (CdId, ScannedBy, ScannedDate, Notes) VALUES (@CdId, @ScannedBy, @ScannedDate, @Notes)";
        const string FILE_DETAILS_INSERT = "INSERT FileDetails (CdId, FileName, FullPath, FileSize, CreateDate) VALUES (@CdId, @FileName, @FullPath, @FileSize, @CreateDate)";

        private void SaveCdContentsToDb(CdDetail cdDetails, List<FileDetail> fileDetails)
        {
            string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            var conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand sqlCmd = new SqlCommand(CD_DETAILS_INSERT, conn);
            sqlCmd.Parameters.AddWithValue("@CdId", cdDetails.CdId);
            sqlCmd.Parameters.AddWithValue("@ScannedBy", cdDetails.ScannedBy);
            sqlCmd.Parameters.AddWithValue("@ScannedDate", cdDetails.ScannedDate);
            sqlCmd.Parameters.AddWithValue("@Notes", cdDetails.Notes);

            sqlCmd.ExecuteNonQuery();

            sqlCmd = new SqlCommand(FILE_DETAILS_INSERT, conn);

            foreach (var file in fileDetails)
            {
                sqlCmd.Parameters.Clear();

                sqlCmd.Parameters.AddWithValue("@CdId", cdDetails.CdId);
                sqlCmd.Parameters.AddWithValue("@FileName", file.Name);
                sqlCmd.Parameters.AddWithValue("@FullPath", file.FullPath);
                sqlCmd.Parameters.AddWithValue("@FileSize", file.Size);
                sqlCmd.Parameters.AddWithValue("@CreateDate", file.CreateDate);

                sqlCmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        private CdDetail GetCdDetails()
        {
            CdDetail result = new CdDetail();
            result.ScannedBy = txtScannedBy.Text;
            result.CdId = txtCDId.Text;
            result.Notes = txtNotes.Text;

            return result;
        }
    }

    public class FileDetail
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
        public long Size { get; set; }
        public DateTime CreateDate { get; set; }
    }

    public class CdDetail
    {
        public string CdId { get; set; }
        public string ScannedBy { get; set; }
        public DateTime ScannedDate { get; set; }
        public string Notes { get; set; }

        public CdDetail()
        {
            ScannedDate = DateTime.Now;
        }

        public bool LooksOk()
        {
            if (CdId == null || CdId == "") { return false; }
            if (ScannedBy == null || ScannedBy == "") { return false; }

            return true;
        }
    }

}
