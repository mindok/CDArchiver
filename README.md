# CDArchiver
Quick and dirty tool to read file listings and add them to a database.

To use, run DBSetup.SQL in a SQL Server database of your choice, edit App.Config to point to the database and run.

Basic usage:
1. Click scan & select CD root drive
2. Enter details - Scanned Date will get updated when you save. ScannedBy & CdId are mandatory, CdId can't already exist in the database.
3. Click Add To Db.

NOTE: This is really sloppy code, no decent error handling, all logic crammed into Form1.cs etc etc. Use at your own risk :)
