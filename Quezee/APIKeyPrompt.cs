using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quezee
{
    public partial class APIKeyPrompt : Form
    {
        public APIKeyPrompt()
        {
            InitializeComponent();

            keyTB.Text = Properties.Settings.Default.APIKey;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (keyTB.Text == Properties.Settings.Default.APIKey)
            {
                this.Close();
            }
            else if (string.IsNullOrEmpty(keyTB.Text))
            {
                string message = "Key field cannot be empty.";
                string title = "Quezee";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                DialogResult result = MessageBox.Show(message, title, buttons, icon);
            }
            else
            {
                Properties.Settings.Default.APIKey = keyTB.Text;
                Properties.Settings.Default.Save();

                string message = "Quezee needs to be restarted to save your changes.";
                string title = "Quezee";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;

                DialogResult result = MessageBox.Show(message, title, buttons, icon);

                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}