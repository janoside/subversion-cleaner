namespace SubversionCleaner {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if ( disposing && (components != null) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.TextBoxDirectoryRoot = new System.Windows.Forms.TextBox();
			this.ButtonBrowse = new System.Windows.Forms.Button();
			this.ButtonClean = new System.Windows.Forms.Button();
			this.PanelLaunch = new System.Windows.Forms.Panel();
			this.PanelCleaning = new System.Windows.Forms.Panel();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.LabelCleaning = new System.Windows.Forms.Label();
			this.PanelLaunch.SuspendLayout();
			this.PanelCleaning.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Directory Root to be Cleaned";
			// 
			// TextBoxDirectoryRoot
			// 
			this.TextBoxDirectoryRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxDirectoryRoot.Location = new System.Drawing.Point(0, 16);
			this.TextBoxDirectoryRoot.Name = "TextBoxDirectoryRoot";
			this.TextBoxDirectoryRoot.Size = new System.Drawing.Size(515, 22);
			this.TextBoxDirectoryRoot.TabIndex = 1;
			// 
			// ButtonBrowse
			// 
			this.ButtonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonBrowse.Location = new System.Drawing.Point(521, 14);
			this.ButtonBrowse.Name = "ButtonBrowse";
			this.ButtonBrowse.Size = new System.Drawing.Size(75, 23);
			this.ButtonBrowse.TabIndex = 2;
			this.ButtonBrowse.Text = "Browse...";
			this.ButtonBrowse.UseVisualStyleBackColor = true;
			this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
			// 
			// ButtonClean
			// 
			this.ButtonClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonClean.Location = new System.Drawing.Point(521, 90);
			this.ButtonClean.Name = "ButtonClean";
			this.ButtonClean.Size = new System.Drawing.Size(78, 23);
			this.ButtonClean.TabIndex = 4;
			this.ButtonClean.Text = "Clean";
			this.ButtonClean.UseVisualStyleBackColor = true;
			this.ButtonClean.Click += new System.EventHandler(this.ButtonClean_Click);
			// 
			// PanelLaunch
			// 
			this.PanelLaunch.Controls.Add(this.ButtonBrowse);
			this.PanelLaunch.Controls.Add(this.ButtonClean);
			this.PanelLaunch.Controls.Add(this.label1);
			this.PanelLaunch.Controls.Add(this.TextBoxDirectoryRoot);
			this.PanelLaunch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelLaunch.Location = new System.Drawing.Point(15, 15);
			this.PanelLaunch.Name = "PanelLaunch";
			this.PanelLaunch.Size = new System.Drawing.Size(599, 113);
			this.PanelLaunch.TabIndex = 5;
			// 
			// PanelCleaning
			// 
			this.PanelCleaning.Controls.Add(this.LabelCleaning);
			this.PanelCleaning.Controls.Add(this.progressBar1);
			this.PanelCleaning.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelCleaning.Location = new System.Drawing.Point(15, 15);
			this.PanelCleaning.Name = "PanelCleaning";
			this.PanelCleaning.Size = new System.Drawing.Size(599, 113);
			this.PanelCleaning.TabIndex = 6;
			this.PanelCleaning.Visible = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(0, 43);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(593, 23);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 0;
			// 
			// LabelCleaning
			// 
			this.LabelCleaning.AutoSize = true;
			this.LabelCleaning.Location = new System.Drawing.Point(0, 27);
			this.LabelCleaning.Name = "LabelCleaning";
			this.LabelCleaning.Size = new System.Drawing.Size(53, 13);
			this.LabelCleaning.TabIndex = 1;
			this.LabelCleaning.Text = "Cleaning";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 143);
			this.Controls.Add(this.PanelCleaning);
			this.Controls.Add(this.PanelLaunch);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(15);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Subversion Cleaner";
			this.PanelLaunch.ResumeLayout(false);
			this.PanelLaunch.PerformLayout();
			this.PanelCleaning.ResumeLayout(false);
			this.PanelCleaning.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TextBoxDirectoryRoot;
		private System.Windows.Forms.Button ButtonBrowse;
		private System.Windows.Forms.Button ButtonClean;
		private System.Windows.Forms.Panel PanelLaunch;
		private System.Windows.Forms.Panel PanelCleaning;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label LabelCleaning;
	}
}

