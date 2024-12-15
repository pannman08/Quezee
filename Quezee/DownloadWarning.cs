using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quezee
{
    public partial class DownloadWarning : Form
    {
        public DownloadWarning()
        {
            InitializeComponent();
        }

        private void DownloadWarning_Load(object sender, EventArgs e)
        {

        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            MasterForm masterForm = (MasterForm)Application.OpenForms["MasterForm"];
            masterForm.ActivateJackTheRipper(Properties.Settings.Default.SelectedVideoId);

            this.Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dontShowAgainCB_CheckedChanged(object sender, EventArgs e)
        {
            if (dontShowAgainCB.Checked == true)
            {
                Properties.Settings.Default.ShowDownloadWarning = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}