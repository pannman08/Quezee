using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quezee
{
    public partial class Player : Form
    {
        public Player(string path)
        {
            InitializeComponent();

            mediaPlayer.URL = path;
            mediaPlayer.settings.autoStart = true;
        }
    }
}