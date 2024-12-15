using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Quezee
{
    public class Updater
    {
        string url = "http://rem.quezee.org/update/";

        public void CheckForUpdates()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string versionNumber = client.DownloadString(url + "version.txt");

                    if (versionNumber == Properties.Settings.Default.Version)
                    {
                        MessageBox.Show("Quezee is up-to-date.", "Quezee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Version " + versionNumber + " is available. Would you like to download it now?", "Quezee", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            Process.Start("http://rem.quezee.org/update/QuezeeSetup.exe");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        public void CheckForUpdatesSil()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string versionNumber = client.DownloadString(url + "version.txt");

                    if (versionNumber == Properties.Settings.Default.Version)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Version " + versionNumber + " is available. Would you like to download it now?", "Quezee", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            Process.Start("http://rem.quezee.org/update/QuezeeSetup.exe");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }
    }
}