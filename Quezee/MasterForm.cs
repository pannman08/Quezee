using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Media;

namespace Quezee
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();

            Results form = new Results("trending", null);
            TabPage tabPage = new TabPage();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            tabPage.Controls.Add(form);
            tabPage.Text = "Trending Videos";

            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;

            form.Show();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            About formTab = new About();
            TabPage tabPage = new TabPage();

            formTab.TopLevel = false;
            formTab.FormBorderStyle = FormBorderStyle.None;
            formTab.Dock = DockStyle.Fill;

            tabPage.Controls.Add(formTab);
            tabPage.Text = "About Quezee";

            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;

            formTab.Show();
        }

        private void infoPanelBtn_Click(object sender, EventArgs e)
        {
            if (infoPanelBtn.Checked == false)
            {
                infoPanel.Visible = false;
                splitter.Visible = false;
            }
            else
            {
                infoPanel.Visible = true;
                splitter.Visible = true;
            }
        }

        private void alwaysOnTopBtn_Click(object sender, EventArgs e)
        {
            if (alwaysOnTopBtn.Checked == false)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }

        private void closeTabBtn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Text == "Jack the Ripper")
            {
                JackTheRipper jackTheRipper = (JackTheRipper)Application.OpenForms["JackTheRipper"];
                jackTheRipper.webBrowser.Navigate("about:blank");

                if (tabControl.TabCount > 1)
                {
                    int selectedIndex = tabControl.SelectedIndex;

                    tabControl.TabPages.Remove(tabControl.SelectedTab);

                    if (tabControl.TabCount > 0)
                    {
                        if (selectedIndex - 1 >= 0)
                        {
                            tabControl.SelectedIndex = selectedIndex - 1;
                        }
                        else
                        {
                            tabControl.SelectedIndex = 0;
                        }
                    }
                }
            }
            else if (tabControl.SelectedTab.Text == "Player")
            {
                Player player = (Player)Application.OpenForms["Player"];
                player.mediaPlayer.Ctlcontrols.stop();

                if (tabControl.TabCount > 1)
                {
                    int selectedIndex = tabControl.SelectedIndex;

                    tabControl.TabPages.Remove(tabControl.SelectedTab);

                    if (tabControl.TabCount > 0)
                    {
                        if (selectedIndex - 1 >= 0)
                        {
                            tabControl.SelectedIndex = selectedIndex - 1;
                        }
                        else
                        {
                            tabControl.SelectedIndex = 0;
                        }
                    }
                }
            }
            else
            {
                if (tabControl.TabCount > 1)
                {
                    int selectedIndex = tabControl.SelectedIndex;

                    tabControl.TabPages.Remove(tabControl.SelectedTab);

                    if (tabControl.TabCount > 0)
                    {
                        if (selectedIndex - 1 >= 0)
                        {
                            tabControl.SelectedIndex = selectedIndex - 1;
                        }
                        else
                        {
                            tabControl.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void changeAPIKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APIKeyPrompt prompt = new APIKeyPrompt();
            prompt.Show();
        }

        private void urlTB_Enter(object sender, EventArgs e)
        {
            if (urlTB.Text == "Insert a URL or Video ID...")
            {
                urlTB.ForeColor = Color.Black;
                urlTB.Clear();
            }
        }

        private void urlTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(urlTB.Text))
            {
                urlTB.ForeColor = Color.DarkGray;
                urlTB.Text = "Insert a URL or Video ID...";
            }
        }

        private void searchTB_Enter(object sender, EventArgs e)
        {
            if (searchTB.Text == "Search...")
            {
                searchTB.ForeColor = Color.Black;
                searchTB.Clear();
            }
        }

        private void searchTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTB.Text))
            {
                searchTB.ForeColor = Color.DarkGray;
                searchTB.Text = "Search...";
            }
        }

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "music:";
        }

        private void gamingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "gaming:";
        }

        private void sportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "sports:";
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "news:";
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "movies:";
        }

        private void educationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "education:";
        }

        private void scienceTechnologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "science-technology:";
        }

        private void tutorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "tutorials:";
        }

        private void comedyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "comedy:";
        }

        private void travelEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "travel:";
        }

        private void animalsPetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "animals-pets:";
        }

        private void foodCookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "food:";
        }

        private void historyCultureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "history:";
        }

        private void kidsFamilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Text = "kids:";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void trendingVideosBtn_Click(object sender, EventArgs e)
        {
            Results form = new Results("trending", null);
            TabPage tabPage = new TabPage();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            tabPage.Controls.Add(form);
            tabPage.Text = "Trending Videos";

            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;

            form.Show();
        }

        private void SearchForVideo()
        {
            if (tabControl.SelectedTab.Text == "Search")
            {
                TabPage existingSearchTab = null;
                foreach (TabPage tab in tabControl.TabPages)
                {
                    if (tab.Text == "Search")
                    {
                        existingSearchTab = tab;
                        break;
                    }
                }

                if (existingSearchTab.Controls.Count > 0)
                {
                    Control oldForm = existingSearchTab.Controls[0];
                    oldForm.Dispose();
                }

                Results newResultsForm = new Results("search", searchTB.Text);

                newResultsForm.TopLevel = false;
                newResultsForm.FormBorderStyle = FormBorderStyle.None;
                newResultsForm.Dock = DockStyle.Fill;

                existingSearchTab.Controls.Add(newResultsForm);

                newResultsForm.Show();
            }
            else
            {
                Results form = new Results("search", searchTB.Text);
                TabPage tabPage = new TabPage();

                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                tabPage.Controls.Add(form);
                tabPage.Text = "Search";

                tabControl.TabPages.Add(tabPage);
                tabControl.SelectedTab = tabPage;

                form.Show();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTB.Text == "Search...")
            {
                MessageBox.Show("Please insert a search term...", "Quezee");
            }
            else if (String.IsNullOrEmpty(searchTB.Text))
            {
                MessageBox.Show("Please insert a search term...", "Quezee");
            }
            else
            {
                SearchForVideo();
            }
        }

        private void searchTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SearchForVideo();
                e.SuppressKeyPress = true;
            }
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            if (urlTB.Text == "Insert a URL or Video ID...")
            {
                MessageBox.Show("Please insert a URL or video ID...", "Quezee");
            }
            else if (String.IsNullOrEmpty(urlTB.Text))
            {
                MessageBox.Show("Please insert a URL or video ID...", "Quezee");
            }
            else
            {
                ActivateJackTheRipper(urlTB.Text);
            }
        }

        private void urlTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ActivateJackTheRipper(urlTB.Text);
                e.SuppressKeyPress = true;
            }
        }

        public void OpenPlayer(string path)
        {
            Player form = new Player(path);
            TabPage tabPage = new TabPage();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            tabPage.Controls.Add(form);
            tabPage.Text = "Player";

            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;

            form.Show();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Select a Video or Audio File";
            openFileDialog.Filter = "Media Files|*.mp4;*.mkv;*.avi;*.mov;*.wmv;*.mp3;*.wav;*.flac;*.aac|All Files|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenPlayer(openFileDialog.FileName);
            }
        }

        private void copyVideoIdBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Properties.Settings.Default.SelectedVideoId);

            string text = "Video ID: \"" + Properties.Settings.Default.SelectedVideoId + "\" has been copied to your clipboard.";
            MessageBox.Show(text, "Quezee", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ActivateJackTheRipper(string videoId)
        {
            JackTheRipper form = new JackTheRipper(videoId);
            TabPage tabPage = new TabPage();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            tabPage.Controls.Add(form);
            tabPage.Text = "Jack the Ripper";

            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;

            form.Show();
        }

        private static bool CheckIfUrlIsValid(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return false;
            }

            string pattern = @"^(https?://)?(www\.)?(youtube|youtu|youtube-nocookie)\.(com|be)/(watch\?v=|embed\/|v\/|e\/|.+\/)([a-zA-Z0-9_-]{11})$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(url);
        }

        private void downloadVideoBtn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ShowDownloadWarning == true)
            {
                DownloadWarning downloadWarning = new DownloadWarning();
                downloadWarning.Show();
            }
            else
            {
                ActivateJackTheRipper(Properties.Settings.Default.SelectedVideoId);
            }
        }

        private void MasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = @"C:\quezee-cache";

            if (Directory.Exists(path))
            {
                try
                {
                    foreach (string file in Directory.GetFiles(path))
                    {
                        File.SetAttributes(file, FileAttributes.Normal);
                        File.Delete(file);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Directory does not exist.");
            }
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Updater updater = new Updater();
            updater.CheckForUpdates();
        }

        private void favoriteVideoBtn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Favorites == null)
            {
                Properties.Settings.Default.Favorites = new System.Collections.Specialized.StringCollection();
            }

            if (Properties.Settings.Default.Favorites.Contains(Properties.Settings.Default.SelectedVideoTitle + " (" + Properties.Settings.Default.SelectedVideoId + ")"))
            {
                MessageBox.Show("Selected video is already in your favorites list.", "Quezee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Properties.Settings.Default.Favorites.Add(Properties.Settings.Default.SelectedVideoTitle + " (" + Properties.Settings.Default.SelectedVideoId + ")");
                Properties.Settings.Default.Save();

                MessageBox.Show("Selected video has been added to your favorites.", "Quezee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFavorites();
            }
        }

        private void LoadFavorites()
        {
            myFavoritesBtn.DropDownItems.Clear();
            
            foreach (string favorite in Properties.Settings.Default.Favorites)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(favorite);
                
                item.Click += Item_Click;
                
                myFavoritesBtn.DropDownItems.Add(item);
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            
            if (clickedItem != null)
            {
                string extractedText = ExtractTextBetweenParentheses(clickedItem.ToString());

                ActivateJackTheRipper(extractedText);
            }
        }

        public static string ExtractTextBetweenParentheses(string input)
        {
            Regex regex = new Regex(@"\((.*?)\)");
            Match match = regex.Match(input);

            return match.Success ? match.Groups[1].Value : string.Empty;
        }

        private void clearFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Are you sure you would like to clear your favorites list?";
            SystemSounds.Exclamation.Play();
            DialogResult result = MessageBox.Show(text, "Quezee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Favorites.Clear();
                Properties.Settings.Default.Save();

                LoadFavorites();
            }
        }

        private void myFavoritesBtn_DropDownOpening(object sender, EventArgs e)
        {
            LoadFavorites();
        }

        private void changeJackServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JackServerPrompt prompt = new JackServerPrompt();
            prompt.Show();
        }

        private void removeFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveFavorites prompt = new RemoveFavorites();
            prompt.Show();
        }

        private TabPage draggedTab;

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            int i;
            for (i = 0; i < tabControl.TabPages.Count; i++)
            {
                if (tabControl.GetTabRect(i).Contains(e.Location))
                {
                    draggedTab = tabControl.TabPages[i];
                    break;
                }
            }
        }

        private void tabControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && draggedTab != null)
            {
                tabControl.DoDragDrop(draggedTab, DragDropEffects.Move);
            }
        }

        private void tabControl_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tabControl_DragDrop(object sender, DragEventArgs e)
        {
            Point point = tabControl.PointToClient(new Point(e.X, e.Y));

            int targetIndex = -1;
            int i;
            for (i = 0; i < tabControl.TabPages.Count; i++)
            {
                if (tabControl.GetTabRect(i).Contains(point))
                {
                    targetIndex = i;
                    break;
                }
            }

            if (targetIndex >= 0 && draggedTab != null)
            {
                int sourceIndex = tabControl.TabPages.IndexOf(draggedTab);
                tabControl.TabPages.RemoveAt(sourceIndex);
                tabControl.TabPages.Insert(targetIndex, draggedTab);

                tabControl.SelectedTab = draggedTab;
            }
        }
    }
}