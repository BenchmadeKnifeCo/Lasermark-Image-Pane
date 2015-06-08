namespace LasermarkImagePane
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GbxImageDisplay = new System.Windows.Forms.GroupBox();
            this.pbxImageDisplay = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.fldImageSaveFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tbxDownloadPath = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDownloadPath = new System.Windows.Forms.Label();
            this.GbxImageDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxImageDisplay
            // 
            this.GbxImageDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxImageDisplay.AutoSize = true;
            this.GbxImageDisplay.Controls.Add(this.pbxImageDisplay);
            this.GbxImageDisplay.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxImageDisplay.Location = new System.Drawing.Point(4, 4);
            this.GbxImageDisplay.Name = "GbxImageDisplay";
            this.GbxImageDisplay.Size = new System.Drawing.Size(416, 254);
            this.GbxImageDisplay.TabIndex = 0;
            this.GbxImageDisplay.TabStop = false;
            this.GbxImageDisplay.Text = "Lasermark Image Display";
            // 
            // pbxImageDisplay
            // 
            this.pbxImageDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImageDisplay.BackColor = System.Drawing.Color.White;
            this.pbxImageDisplay.Location = new System.Drawing.Point(7, 21);
            this.pbxImageDisplay.Name = "pbxImageDisplay";
            this.pbxImageDisplay.Size = new System.Drawing.Size(402, 222);
            this.pbxImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImageDisplay.TabIndex = 0;
            this.pbxImageDisplay.TabStop = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownload.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(351, 264);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(69, 28);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tbxDownloadPath
            // 
            this.tbxDownloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxDownloadPath.BackColor = System.Drawing.Color.White;
            this.tbxDownloadPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDownloadPath.Location = new System.Drawing.Point(92, 265);
            this.tbxDownloadPath.Multiline = true;
            this.tbxDownloadPath.Name = "tbxDownloadPath";
            this.tbxDownloadPath.ReadOnly = true;
            this.tbxDownloadPath.Size = new System.Drawing.Size(251, 28);
            this.tbxDownloadPath.TabIndex = 2;
            // 
            // lblDownloadPath
            // 
            this.lblDownloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDownloadPath.AutoSize = true;
            this.lblDownloadPath.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloadPath.Location = new System.Drawing.Point(8, 271);
            this.lblDownloadPath.Name = "lblDownloadPath";
            this.lblDownloadPath.Size = new System.Drawing.Size(82, 13);
            this.lblDownloadPath.TabIndex = 1;
            this.lblDownloadPath.Text = "Download Path :";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.lblDownloadPath);
            this.Controls.Add(this.tbxDownloadPath);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.GbxImageDisplay);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(426, 301);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.GbxImageDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxImageDisplay;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.FolderBrowserDialog fldImageSaveFolder;
        private System.Windows.Forms.TextBox tbxDownloadPath;
        private System.Windows.Forms.PictureBox pbxImageDisplay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDownloadPath;
    }
}
