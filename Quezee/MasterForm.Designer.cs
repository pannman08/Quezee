namespace Quezee
{
    partial class MasterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.urlTB = new System.Windows.Forms.ToolStripTextBox();
            this.goBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchTB = new System.Windows.Forms.ToolStripTextBox();
            this.searchBtn = new System.Windows.Forms.ToolStripButton();
            this.settingsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.changeAPIKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopBtn = new System.Windows.Forms.ToolStripButton();
            this.infoPanelBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.closeTabBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.openFileBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.trendingVideosBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriesBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scienceTechnologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comedyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.travelEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalsPetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodCookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyCultureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kidsFamilyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.viewCountLbl = new System.Windows.Forms.Label();
            this.downloadVideoBtn = new System.Windows.Forms.Button();
            this.copyVideoIdBtn = new System.Windows.Forms.Button();
            this.videoIdLbl = new System.Windows.Forms.Label();
            this.channelLbl = new System.Windows.Forms.Label();
            this.videoTitleLbl = new System.Windows.Forms.Label();
            this.thumbnailPB = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.splitter = new System.Windows.Forms.Splitter();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPB)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urlTB,
            this.goBtn,
            this.toolStripSeparator1,
            this.searchTB,
            this.searchBtn,
            this.settingsBtn,
            this.alwaysOnTopBtn,
            this.infoPanelBtn,
            this.toolStripSeparator5,
            this.toolStripSeparator7,
            this.closeTabBtn,
            this.toolStripSeparator8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(714, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // urlTB
            // 
            this.urlTB.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.urlTB.ForeColor = System.Drawing.Color.DarkGray;
            this.urlTB.Margin = new System.Windows.Forms.Padding(1, -1, 1, 0);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(200, 26);
            this.urlTB.Text = "Insert a URL or Video ID...";
            this.urlTB.Enter += new System.EventHandler(this.urlTB_Enter);
            this.urlTB.Leave += new System.EventHandler(this.urlTB_Leave);
            // 
            // goBtn
            // 
            this.goBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goBtn.Image = global::Quezee.Properties.Resources.w98_trust0;
            this.goBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(23, 22);
            this.goBtn.Text = "Go...";
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.searchTB.ForeColor = System.Drawing.Color.DarkGray;
            this.searchTB.Margin = new System.Windows.Forms.Padding(0, -1, 1, 0);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(200, 26);
            this.searchTB.Text = "Search...";
            this.searchTB.Enter += new System.EventHandler(this.searchTB_Enter);
            this.searchTB.Leave += new System.EventHandler(this.searchTB_Leave);
            // 
            // searchBtn
            // 
            this.searchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchBtn.Image = global::Quezee.Properties.Resources.magnifying_glass_3;
            this.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(23, 22);
            this.searchBtn.Text = "Search...";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeAPIKeyToolStripMenuItem,
            this.toolStripSeparator6,
            this.aboutBtn});
            this.settingsBtn.Image = global::Quezee.Properties.Resources.w98_settings_gear;
            this.settingsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(29, 22);
            this.settingsBtn.Text = "Settings";
            // 
            // changeAPIKeyToolStripMenuItem
            // 
            this.changeAPIKeyToolStripMenuItem.Image = global::Quezee.Properties.Resources.w2k_key_2;
            this.changeAPIKeyToolStripMenuItem.Name = "changeAPIKeyToolStripMenuItem";
            this.changeAPIKeyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.changeAPIKeyToolStripMenuItem.Text = "Change API Key...";
            this.changeAPIKeyToolStripMenuItem.Click += new System.EventHandler(this.changeAPIKeyToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(172, 6);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(175, 22);
            this.aboutBtn.Text = "About Quezee...";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // alwaysOnTopBtn
            // 
            this.alwaysOnTopBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.alwaysOnTopBtn.CheckOnClick = true;
            this.alwaysOnTopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alwaysOnTopBtn.Image = global::Quezee.Properties.Resources.w98_accessibility_two_windows;
            this.alwaysOnTopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alwaysOnTopBtn.Name = "alwaysOnTopBtn";
            this.alwaysOnTopBtn.Size = new System.Drawing.Size(23, 22);
            this.alwaysOnTopBtn.Text = "Keep window on top...";
            this.alwaysOnTopBtn.Click += new System.EventHandler(this.alwaysOnTopBtn_Click);
            // 
            // infoPanelBtn
            // 
            this.infoPanelBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoPanelBtn.Checked = true;
            this.infoPanelBtn.CheckOnClick = true;
            this.infoPanelBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.infoPanelBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoPanelBtn.Image = global::Quezee.Properties.Resources.w2k_info;
            this.infoPanelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoPanelBtn.Name = "infoPanelBtn";
            this.infoPanelBtn.Size = new System.Drawing.Size(23, 22);
            this.infoPanelBtn.Text = "See video info...";
            this.infoPanelBtn.Click += new System.EventHandler(this.infoPanelBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // closeTabBtn
            // 
            this.closeTabBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeTabBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeTabBtn.Image = global::Quezee.Properties.Resources.wxp_240;
            this.closeTabBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeTabBtn.Name = "closeTabBtn";
            this.closeTabBtn.Size = new System.Drawing.Size(23, 22);
            this.closeTabBtn.Text = "Close selected tab...";
            this.closeTabBtn.Click += new System.EventHandler(this.closeTabBtn_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator8.Margin = new System.Windows.Forms.Padding(0, 0, -1, 0);
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileBtn,
            this.toolStripSeparator3,
            this.trendingVideosBtn,
            this.toolStripSeparator4,
            this.categoriesBtn,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(714, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip3";
            // 
            // openFileBtn
            // 
            this.openFileBtn.Image = global::Quezee.Properties.Resources.w2k_2;
            this.openFileBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileBtn.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(81, 22);
            this.openFileBtn.Text = "Open a File";
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // trendingVideosBtn
            // 
            this.trendingVideosBtn.Image = global::Quezee.Properties.Resources.w98_newspaper;
            this.trendingVideosBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.trendingVideosBtn.Name = "trendingVideosBtn";
            this.trendingVideosBtn.Size = new System.Drawing.Size(103, 22);
            this.trendingVideosBtn.Text = "Trending Videos";
            this.trendingVideosBtn.Click += new System.EventHandler(this.trendingVideosBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem,
            this.gamingToolStripMenuItem,
            this.sportsToolStripMenuItem,
            this.newsToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.educationToolStripMenuItem,
            this.scienceTechnologyToolStripMenuItem,
            this.tutorialsToolStripMenuItem,
            this.comedyToolStripMenuItem,
            this.travelEventsToolStripMenuItem,
            this.animalsPetsToolStripMenuItem,
            this.foodCookingToolStripMenuItem,
            this.historyCultureToolStripMenuItem,
            this.kidsFamilyToolStripMenuItem});
            this.categoriesBtn.Image = global::Quezee.Properties.Resources.w98_catalog;
            this.categoriesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(117, 22);
            this.categoriesBtn.Text = "Video Categories";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.musicToolStripMenuItem_Click);
            // 
            // gamingToolStripMenuItem
            // 
            this.gamingToolStripMenuItem.Name = "gamingToolStripMenuItem";
            this.gamingToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gamingToolStripMenuItem.Text = "Gaming";
            this.gamingToolStripMenuItem.Click += new System.EventHandler(this.gamingToolStripMenuItem_Click);
            // 
            // sportsToolStripMenuItem
            // 
            this.sportsToolStripMenuItem.Name = "sportsToolStripMenuItem";
            this.sportsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sportsToolStripMenuItem.Text = "Sports";
            this.sportsToolStripMenuItem.Click += new System.EventHandler(this.sportsToolStripMenuItem_Click);
            // 
            // newsToolStripMenuItem
            // 
            this.newsToolStripMenuItem.Name = "newsToolStripMenuItem";
            this.newsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.newsToolStripMenuItem.Text = "News";
            this.newsToolStripMenuItem.Click += new System.EventHandler(this.newsToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // educationToolStripMenuItem
            // 
            this.educationToolStripMenuItem.Name = "educationToolStripMenuItem";
            this.educationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.educationToolStripMenuItem.Text = "Education";
            this.educationToolStripMenuItem.Click += new System.EventHandler(this.educationToolStripMenuItem_Click);
            // 
            // scienceTechnologyToolStripMenuItem
            // 
            this.scienceTechnologyToolStripMenuItem.Name = "scienceTechnologyToolStripMenuItem";
            this.scienceTechnologyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.scienceTechnologyToolStripMenuItem.Text = "Science && Technology";
            this.scienceTechnologyToolStripMenuItem.Click += new System.EventHandler(this.scienceTechnologyToolStripMenuItem_Click);
            // 
            // tutorialsToolStripMenuItem
            // 
            this.tutorialsToolStripMenuItem.Name = "tutorialsToolStripMenuItem";
            this.tutorialsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.tutorialsToolStripMenuItem.Text = "Tutorials";
            this.tutorialsToolStripMenuItem.Click += new System.EventHandler(this.tutorialsToolStripMenuItem_Click);
            // 
            // comedyToolStripMenuItem
            // 
            this.comedyToolStripMenuItem.Name = "comedyToolStripMenuItem";
            this.comedyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.comedyToolStripMenuItem.Text = "Comedy";
            this.comedyToolStripMenuItem.Click += new System.EventHandler(this.comedyToolStripMenuItem_Click);
            // 
            // travelEventsToolStripMenuItem
            // 
            this.travelEventsToolStripMenuItem.Name = "travelEventsToolStripMenuItem";
            this.travelEventsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.travelEventsToolStripMenuItem.Text = "Travel && Events";
            this.travelEventsToolStripMenuItem.Click += new System.EventHandler(this.travelEventsToolStripMenuItem_Click);
            // 
            // animalsPetsToolStripMenuItem
            // 
            this.animalsPetsToolStripMenuItem.Name = "animalsPetsToolStripMenuItem";
            this.animalsPetsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.animalsPetsToolStripMenuItem.Text = "Animals && Pets";
            this.animalsPetsToolStripMenuItem.Click += new System.EventHandler(this.animalsPetsToolStripMenuItem_Click);
            // 
            // foodCookingToolStripMenuItem
            // 
            this.foodCookingToolStripMenuItem.Name = "foodCookingToolStripMenuItem";
            this.foodCookingToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.foodCookingToolStripMenuItem.Text = "Food && Cooking";
            this.foodCookingToolStripMenuItem.Click += new System.EventHandler(this.foodCookingToolStripMenuItem_Click);
            // 
            // historyCultureToolStripMenuItem
            // 
            this.historyCultureToolStripMenuItem.Name = "historyCultureToolStripMenuItem";
            this.historyCultureToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.historyCultureToolStripMenuItem.Text = "History && Culture";
            this.historyCultureToolStripMenuItem.Click += new System.EventHandler(this.historyCultureToolStripMenuItem_Click);
            // 
            // kidsFamilyToolStripMenuItem
            // 
            this.kidsFamilyToolStripMenuItem.Name = "kidsFamilyToolStripMenuItem";
            this.kidsFamilyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kidsFamilyToolStripMenuItem.Text = "Kids && Family";
            this.kidsFamilyToolStripMenuItem.Click += new System.EventHandler(this.kidsFamilyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.infoPanel.Controls.Add(this.viewCountLbl);
            this.infoPanel.Controls.Add(this.downloadVideoBtn);
            this.infoPanel.Controls.Add(this.copyVideoIdBtn);
            this.infoPanel.Controls.Add(this.videoIdLbl);
            this.infoPanel.Controls.Add(this.channelLbl);
            this.infoPanel.Controls.Add(this.videoTitleLbl);
            this.infoPanel.Controls.Add(this.thumbnailPB);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoPanel.Location = new System.Drawing.Point(504, 50);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(210, 458);
            this.infoPanel.TabIndex = 6;
            // 
            // viewCountLbl
            // 
            this.viewCountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.viewCountLbl.AutoEllipsis = true;
            this.viewCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCountLbl.Location = new System.Drawing.Point(4, 197);
            this.viewCountLbl.Name = "viewCountLbl";
            this.viewCountLbl.Size = new System.Drawing.Size(204, 16);
            this.viewCountLbl.TabIndex = 14;
            this.viewCountLbl.Text = "Views:";
            // 
            // downloadVideoBtn
            // 
            this.downloadVideoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadVideoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadVideoBtn.Enabled = false;
            this.downloadVideoBtn.Location = new System.Drawing.Point(3, 408);
            this.downloadVideoBtn.Name = "downloadVideoBtn";
            this.downloadVideoBtn.Size = new System.Drawing.Size(204, 23);
            this.downloadVideoBtn.TabIndex = 12;
            this.downloadVideoBtn.TabStop = false;
            this.downloadVideoBtn.Text = "Download Video";
            this.downloadVideoBtn.UseVisualStyleBackColor = true;
            this.downloadVideoBtn.Click += new System.EventHandler(this.downloadVideoBtn_Click);
            // 
            // copyVideoIdBtn
            // 
            this.copyVideoIdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.copyVideoIdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyVideoIdBtn.Enabled = false;
            this.copyVideoIdBtn.Location = new System.Drawing.Point(3, 431);
            this.copyVideoIdBtn.Name = "copyVideoIdBtn";
            this.copyVideoIdBtn.Size = new System.Drawing.Size(204, 23);
            this.copyVideoIdBtn.TabIndex = 11;
            this.copyVideoIdBtn.TabStop = false;
            this.copyVideoIdBtn.Text = "Copy Video ID";
            this.copyVideoIdBtn.UseVisualStyleBackColor = true;
            this.copyVideoIdBtn.Click += new System.EventHandler(this.copyVideoIdBtn_Click);
            // 
            // videoIdLbl
            // 
            this.videoIdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoIdLbl.AutoEllipsis = true;
            this.videoIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoIdLbl.Location = new System.Drawing.Point(4, 154);
            this.videoIdLbl.Name = "videoIdLbl";
            this.videoIdLbl.Size = new System.Drawing.Size(204, 16);
            this.videoIdLbl.TabIndex = 10;
            this.videoIdLbl.Text = "Video ID:";
            // 
            // channelLbl
            // 
            this.channelLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.channelLbl.AutoEllipsis = true;
            this.channelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelLbl.Location = new System.Drawing.Point(4, 175);
            this.channelLbl.Name = "channelLbl";
            this.channelLbl.Size = new System.Drawing.Size(204, 16);
            this.channelLbl.TabIndex = 7;
            this.channelLbl.Text = "Channel:";
            // 
            // videoTitleLbl
            // 
            this.videoTitleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoTitleLbl.AutoEllipsis = true;
            this.videoTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoTitleLbl.Location = new System.Drawing.Point(2, 127);
            this.videoTitleLbl.Name = "videoTitleLbl";
            this.videoTitleLbl.Size = new System.Drawing.Size(206, 23);
            this.videoTitleLbl.TabIndex = 1;
            this.videoTitleLbl.Text = "Video Title";
            this.videoTitleLbl.UseMnemonic = false;
            // 
            // thumbnailPB
            // 
            this.thumbnailPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thumbnailPB.Location = new System.Drawing.Point(3, 2);
            this.thumbnailPB.Name = "thumbnailPB";
            this.thumbnailPB.Size = new System.Drawing.Size(206, 120);
            this.thumbnailPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnailPB.TabIndex = 0;
            this.thumbnailPB.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(504, 458);
            this.tabControl.TabIndex = 11;
            this.tabControl.TabStop = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.Control;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(503, 50);
            this.splitter.MinExtra = 210;
            this.splitter.MinSize = 210;
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(1, 458);
            this.splitter.TabIndex = 12;
            this.splitter.TabStop = false;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 508);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quezee 1.0 Alpha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripTextBox searchTB;
        public System.Windows.Forms.ToolStripButton searchBtn;
        private System.Windows.Forms.ToolStripDropDownButton settingsBtn;
        private System.Windows.Forms.ToolStripMenuItem changeAPIKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem aboutBtn;
        private System.Windows.Forms.ToolStripButton alwaysOnTopBtn;
        private System.Windows.Forms.ToolStripButton infoPanelBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton closeTabBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton openFileBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton trendingVideosBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton categoriesBtn;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scienceTechnologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comedyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem travelEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalsPetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodCookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyCultureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kidsFamilyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel infoPanel;
        public System.Windows.Forms.Label viewCountLbl;
        public System.Windows.Forms.Button downloadVideoBtn;
        public System.Windows.Forms.Button copyVideoIdBtn;
        public System.Windows.Forms.Label videoIdLbl;
        public System.Windows.Forms.Label channelLbl;
        public System.Windows.Forms.Label videoTitleLbl;
        public System.Windows.Forms.PictureBox thumbnailPB;
        private System.Windows.Forms.Splitter splitter;
        public System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripTextBox urlTB;
        private System.Windows.Forms.ToolStripButton goBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

