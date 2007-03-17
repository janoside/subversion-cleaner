using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SubversionCleaner {

	public partial class MainForm : Form {

		private Stopwatch fStopwatch;

		private int fDirectoriesDeleted;

		private int fFilesDeleted;

		public MainForm() {
			InitializeComponent();

			this.fStopwatch = new Stopwatch();
		}

		private void ButtonBrowse_Click(object sender, EventArgs e) {
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.Description = "Select a directory to clean Subversion metadata from.";
			fbd.ShowNewFolderButton = false;

			DialogResult dr = fbd.ShowDialog();
			if ( dr == DialogResult.OK ) {
				this.TextBoxDirectoryRoot.Text = fbd.SelectedPath;
			}
		}

		private void ButtonClean_Click(object sender, EventArgs e) {
			this.fDirectoriesDeleted = 0;
			this.fFilesDeleted = 0;

			this.fStopwatch.Reset();
			this.fStopwatch.Start();

			this.PanelLaunch.Visible = false;
			this.PanelCleaning.Visible = true;

			this.CleanDirectory(this.TextBoxDirectoryRoot.Text);

			this.PanelLaunch.Visible = true;
			this.PanelCleaning.Visible = false;

			MessageBox.Show(
				string.Format(
					"Deleted {0} directories and {1} files in {2} seconds",
					this.fDirectoriesDeleted,
					this.fFilesDeleted,
					this.fStopwatch.ElapsedMilliseconds / 1000.0f),
				"Cleanup Finished");
		}

		private void CleanDirectory(string directory) {
			string[] children = Directory.GetDirectories(directory);
			foreach ( string childDir in children ) {
				if ( childDir.EndsWith("\\.svn") ) {
					this.CleanSvnDirectory(childDir);
				} else {
					this.CleanDirectory(childDir);
				}
			}
		}

		private void CleanSvnDirectory(string dir) {
			this.LabelCleaning.Text = "Cleaning " + dir;
			this.Refresh();

			string[] files = Directory.GetFiles(dir);
			foreach ( string file in files ) {
				File.SetAttributes(file, FileAttributes.Normal);
				FileAttributes fa = File.GetAttributes(file);
				File.Delete(file);
				this.fFilesDeleted++;
			}

			string[] children = Directory.GetDirectories(dir);
			foreach ( string childDir in children ) {
				this.CleanSvnDirectory(childDir);
			}
			
			Directory.Delete(dir);
			this.fDirectoriesDeleted++;
		}
	}
}