using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Quezee
{
    public partial class RemoveFavorites : Form
    {
        public RemoveFavorites()
        {
            InitializeComponent();

            foreach (string favorite in Properties.Settings.Default.Favorites)
            {
                listBox.Items.Add(favorite);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string selectedItem = listBox.SelectedItem.ToString();

                Properties.Settings.Default.Favorites.Remove(selectedItem);
                Properties.Settings.Default.Save();

                listBox.DataSource = null;
                listBox.DataSource = Properties.Settings.Default.Favorites;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            DialogResult result = MessageBox.Show("Are you sure you would like to clear your favorites list?", "Quezee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                listBox.Items.Clear();

                Properties.Settings.Default.Favorites.Clear();
                Properties.Settings.Default.Save();
            }
        }
    }
}