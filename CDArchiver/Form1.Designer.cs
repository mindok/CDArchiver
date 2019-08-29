namespace CDArchiver
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.grdFiles = new System.Windows.Forms.DataGridView();
            this.txtCDId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScanDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScannedBy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnCdIdGen = new System.Windows.Forms.Button();
            this.btnAddToDb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.AutoSize = true;
            this.debugInstructionsLabel.Location = new System.Drawing.Point(25, 57);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(171, 17);
            this.debugInstructionsLabel.TabIndex = 1;
            this.debugInstructionsLabel.Text = "Insert CD then click \'Scan\'";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(28, 86);
            this.btnScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(130, 34);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(22, 9);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(335, 31);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Quick \'n\' Dirty CD Scanner";
            // 
            // grdFiles
            // 
            this.grdFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFiles.Location = new System.Drawing.Point(382, 12);
            this.grdFiles.Name = "grdFiles";
            this.grdFiles.RowHeadersWidth = 51;
            this.grdFiles.RowTemplate.Height = 18;
            this.grdFiles.Size = new System.Drawing.Size(756, 602);
            this.grdFiles.TabIndex = 5;
            // 
            // txtCDId
            // 
            this.txtCDId.Location = new System.Drawing.Point(28, 151);
            this.txtCDId.Name = "txtCDId";
            this.txtCDId.Size = new System.Drawing.Size(177, 22);
            this.txtCDId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "CD Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time Scanned";
            // 
            // txtScanDate
            // 
            this.txtScanDate.Location = new System.Drawing.Point(28, 204);
            this.txtScanDate.Name = "txtScanDate";
            this.txtScanDate.Size = new System.Drawing.Size(177, 22);
            this.txtScanDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Scanned By";
            // 
            // txtScannedBy
            // 
            this.txtScannedBy.Location = new System.Drawing.Point(28, 263);
            this.txtScannedBy.Name = "txtScannedBy";
            this.txtScannedBy.Size = new System.Drawing.Size(177, 22);
            this.txtScannedBy.TabIndex = 10;
            this.txtScannedBy.Leave += new System.EventHandler(this.TxtScannedBy_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(28, 323);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(280, 179);
            this.txtNotes.TabIndex = 12;
            // 
            // btnCdIdGen
            // 
            this.btnCdIdGen.Location = new System.Drawing.Point(210, 152);
            this.btnCdIdGen.Name = "btnCdIdGen";
            this.btnCdIdGen.Size = new System.Drawing.Size(54, 26);
            this.btnCdIdGen.TabIndex = 14;
            this.btnCdIdGen.Text = "Gen";
            this.btnCdIdGen.UseVisualStyleBackColor = true;
            this.btnCdIdGen.Click += new System.EventHandler(this.BtnCdIdGen_Click);
            // 
            // btnAddToDb
            // 
            this.btnAddToDb.Location = new System.Drawing.Point(28, 518);
            this.btnAddToDb.Name = "btnAddToDb";
            this.btnAddToDb.Size = new System.Drawing.Size(130, 34);
            this.btnAddToDb.TabIndex = 15;
            this.btnAddToDb.Text = "Add To Db";
            this.btnAddToDb.UseVisualStyleBackColor = true;
            this.btnAddToDb.Click += new System.EventHandler(this.BtnAddToDb_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 626);
            this.Controls.Add(this.btnAddToDb);
            this.Controls.Add(this.btnCdIdGen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtScannedBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScanDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCDId);
            this.Controls.Add(this.grdFiles);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.debugInstructionsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Quick \'n\' Dirty CD Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.DataGridView grdFiles;
        private System.Windows.Forms.TextBox txtCDId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScanDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScannedBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnCdIdGen;
        private System.Windows.Forms.Button btnAddToDb;
    }
}

