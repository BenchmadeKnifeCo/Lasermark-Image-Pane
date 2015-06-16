using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace LasermarkImagePane
{
    public partial class UserControl1 : UserControl
    {
        string _ImageName = "";
        string _Company = "";

        public UserControl1()
        {
            InitializeComponent();

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_ImageName))
                {

                    DialogResult result = MessageBox.Show("Image will be downloaded to the path " + Properties.Settings.Default.DefaultDownloadPath + "\n" + "To cancel download, click Cancel.", "Image Download", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        /* Download */
                        using (var client = new WebClient())
                        {
                            string storePath = Properties.Settings.Default.ImageStorePath + _ImageName;
                            string downloadPath = Properties.Settings.Default.DefaultDownloadPath + _ImageName;
                            client.DownloadFile(storePath, downloadPath);
                        }
                    }
                    else
                    {
                        /* Cancel. Perform No action */
                    }

                }
                else
                {
                    MessageBox.Show("Please select a valid Image comment line");

                }
            }
            catch (Exception)
            {

            }
        }

        public void GetImage(string ImageName, string Company)
        {
            if (!string.IsNullOrWhiteSpace(ImageName))
            {
                _ImageName = ImageName.Trim();
                _Company = Company.Trim();

                UserControl1_Load(this, EventArgs.Empty);
            }
            else
            {

            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                pbxImageDisplay.Image = null;
                tbxDownloadPath.Text = Properties.Settings.Default.DefaultDownloadPath;

                pbxImageDisplay.Load(Properties.Settings.Default.ImageStorePath + _ImageName);
            }
            catch (Exception)
            {
                pbxImageDisplay.Image = null;
                pbxImageDisplay.Refresh();
            }
        }

        public void SaveImageToFolder()
        {
            if (System.IO.Directory.Exists(tbxDownloadPath.Text))
            {

            }
        }

    }
}
