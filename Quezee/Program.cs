using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using System.Diagnostics;

namespace Quezee
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string folderPath = @"C:\quezee-cache";

            Updater updater = new Updater();
            updater.CheckForUpdatesSil();

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!IsInternetAvailable())
            {
                MessageBox.Show("Quezee needs an Internet connection to run.", "Quezee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.APIKey))
            {
                string message = "YouTube API key is missing. Would you like to add a valid key?";
                string title = "Quezee";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;

                DialogResult result = MessageBox.Show(message, title, buttons, icon);

                if (result == DialogResult.Yes)
                {
                    Application.Run(new APIKeyPrompt());
                    return;
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                    return;
                }
            }

            Application.Run(new MasterForm());
        }

        static bool IsInternetAvailable()
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send("8.8.8.8", 3000);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}