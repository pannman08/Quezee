using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Quezee
{
    public partial class JackTheRipper : Form
    {
        public JackTheRipper(string videoId)
        {
            InitializeComponent();

            string encodedVideoId = HttpUtility.UrlEncode(videoId);
            string url = "http://" + Properties.Settings.Default.JackServerAddress + "/JackTheRipper/index.php?url=" + encodedVideoId;
            webBrowser.Url = new Uri(url);
        }

        public static void DownloadFile(string fileUrl, string filePath)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fileUrl);
                    request.Method = "GET";
                    request.Proxy = null;
                    request.Timeout = 10000;

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    using (Stream responseStream = response.GetResponseStream())
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        byte[] buffer = new byte[8192];
                        int bytesRead;
                        while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileStream.Write(buffer, 0, bytesRead);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Download error: " + ex.Message);
                }
            }
        }

        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            statusLbl.Text = "Downloading...";
            statusBar.ProgressBar.Style = ProgressBarStyle.Marquee;
        }

        public static string GetUrlParameter(string url, string parameterName)
        {
            Uri uri = new Uri(url);

            System.Collections.Specialized.NameValueCollection queryParameters = HttpUtility.ParseQueryString(uri.Query);

            return queryParameters[parameterName];
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Uri currentUrl = webBrowser.Url;

            statusLbl.Text = "";
            statusBar.ProgressBar.Style = ProgressBarStyle.Blocks;

            string play = "http://" + Properties.Settings.Default.JackServerAddress + "/JackTheRipper/play.php";
            string save = "http://" + Properties.Settings.Default.JackServerAddress + "/JackTheRipper/save.php";

            if (webBrowser.Url == new Uri(play))
            {
                MasterForm masterForm = (MasterForm)Application.OpenForms["MasterForm"];

                string path = webBrowser.Document.Body.InnerText;
                string fileUrl = "http://" + Properties.Settings.Default.JackServerAddress + "/JackTheRipper" + path;

                Random random = new Random();
                int randomNumber = random.Next(0, 5001);

                string newFilePath = @"C:\quezee-cache\video" + randomNumber + ".wmv";
                DownloadFile(fileUrl, newFilePath);

                webBrowser.Navigate("http://" + Properties.Settings.Default.JackServerAddress + "/JackTheRipper/delete.php");

                masterForm.tabControl.TabPages.Remove(masterForm.tabControl.SelectedTab);

                masterForm.OpenPlayer(newFilePath);
            }
            else if (webBrowser.Url == new Uri(save))
            {
                MasterForm masterForm = (MasterForm)Application.OpenForms["MasterForm"];

                string path = webBrowser.Document.Body.InnerText;
                string fileUrl = "http://" + Properties.Settings.Default.JackServerAddress + "/JackTheRipper" + path;

                Random random = new Random();
                int randomNumber = random.Next(0, 5001);

                string videoName = "video" + randomNumber + ".wmv";
                string newFilePath = @"C:\quezee-cache\" + videoName;
                DownloadFile(fileUrl, newFilePath);

                webBrowser.Navigate("http://" + Properties.Settings.Default.JackServerAddress + "/JackTheRipper/delete.php");

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.Filter = "WMV files (*.wmv)|*.wmv";
                dialog.FileName = videoName;
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    File.Move(newFilePath, dialog.FileName);

                    masterForm.tabControl.TabPages.Remove(masterForm.tabControl.SelectedTab);
                }
            }
        }

        private void JackTheRipper_FormClosing(object sender, FormClosingEventArgs e)
        {
            webBrowser.Dispose();
        }
    }
}