using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Quezee
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void quezeeWebsiteLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://quezee.org");
        }

        private void gitHubPageLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/pannman08/Quezee");
        }
    }
}