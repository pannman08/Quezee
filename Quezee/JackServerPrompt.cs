using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quezee
{
    public partial class JackServerPrompt : Form
    {
        public JackServerPrompt()
        {
            InitializeComponent();

            addressTB.Text = Properties.Settings.Default.JackServerAddress;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (addressTB.Text == Properties.Settings.Default.JackServerAddress)
            {
                this.Close();
            }
            else if (string.IsNullOrEmpty(addressTB.Text))
            {
                string message = "Key field cannot be empty.";
                string title = "Quezee";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                DialogResult result = MessageBox.Show(message, title, buttons, icon);
            }
            else
            {
                Properties.Settings.Default.JackServerAddress = addressTB.Text;
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