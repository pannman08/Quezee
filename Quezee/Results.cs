using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Web;
using System.IO;

namespace Quezee
{
    public partial class Results : Form
    {
        private string displayMode;
        private string ApiKey = Properties.Settings.Default.APIKey;
        private const string BaseUrl = "https://www.googleapis.com/youtube/v3/";

        // Welcome to the gates of hell. Repent for your sins while you still can...

        public Results(string mode, string searchText)
        {
            InitializeComponent();
            displayMode = mode;

            ConfigureListView();
            LoadResults(searchText);
        }

        private void ConfigureListView()
        {
            resultsLV.View = System.Windows.Forms.View.Details;
            resultsLV.Columns.Add("Title", 200);
            resultsLV.Columns.Add("Video ID", 100);
            resultsLV.Columns.Add("Channel", 200);
            resultsLV.Columns.Add("Views", 100);
        }

        public void LoadResults(string searchText)
        {
            try
            {
                List<Video> videos;

                if (displayMode == "trending")
                {
                    videos = GetTrendingVideos();
                }
                else if (displayMode == "search")
                {
                    if (string.IsNullOrEmpty(searchText))
                    {
                        MessageBox.Show("Search text cannot be empty.");
                        return;
                    }

                    videos = GetSearchResults(searchText);
                }
                else
                {
                    MessageBox.Show("Invalid display mode.");
                    return;
                }

                PopulateListView(videos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading results: " + ex.Message);
            }
        }

        private List<Video> GetTrendingVideos()
        {
            using (WebClient client = new WebClient())
            {
                string url = BaseUrl + "videos?part=snippet&chart=mostPopular&regionCode=US&maxResults=20&key=" + ApiKey;
                string response = client.DownloadString(url);
                return ParseVideoList(response, true);
            }
        }

        public List<Video> GetSearchResults(string query)
        {
            using (WebClient client = new WebClient())
            {
                string url = BaseUrl + "search?part=snippet&type=video&q=" + Uri.EscapeDataString(query) + "&maxResults=20&key=" + ApiKey;
                string response = client.DownloadString(url);
                return ParseVideoList(response, false);
            }
        }

        private List<Video> ParseVideoList(string jsonResponse, bool isTrending)
        {
            List<Video> videos = new List<Video>();
            JObject json = JObject.Parse(jsonResponse);

            foreach (JObject item in json["items"])
            {
                string videoId = isTrending ? item["id"].ToString() : item["id"]["videoId"].ToString();

                Video video = new Video();
                video.Title = item["snippet"]["title"].ToString();
                video.VideoId = videoId;
                video.Channel = item["snippet"]["channelTitle"].ToString();
                video.Views = GetViewCount(videoId);

                string thumbnailUrl = item["snippet"]["thumbnails"]["high"]["url"].ToString();
                video.ThumbnailUrl = thumbnailUrl;

                videos.Add(video);
            }

            return videos;
        }

        private string GetViewCount(string videoId)
        {
            using (WebClient client = new WebClient())
            {
                string url = BaseUrl + "videos?part=statistics&id=" + videoId + "&key=" + ApiKey;
                string response = client.DownloadString(url);

                JObject json = JObject.Parse(response);
                string viewCount = json["items"][0]["statistics"]["viewCount"].ToString();

                return FormatViewCount(viewCount);
            }
        }

        private string FormatViewCount(string viewCount)
        {
            // Gobbledygook baloney for adding commas to a super duper big nubber. Keep walkin pal!

            long count;

            if (long.TryParse(viewCount, out count))
            {
                return String.Format("{0:#,0}", count);
            }

            return viewCount;
        }

        private System.Drawing.Image LoadImageFromUrl(string url)
        {
            using (WebClient client = new WebClient())
            {
                byte[] imageBytes = client.DownloadData(url);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return System.Drawing.Image.FromStream(ms);
                }
            }
        }

        private void PopulateListView(List<Video> videos)
        {
            resultsLV.Items.Clear();

            foreach (Video video in videos)
            {
                string decodedTitle = HttpUtility.HtmlDecode(video.Title);
                string decodedChannel = HttpUtility.HtmlDecode(video.Channel);
                string decodedViews = HttpUtility.HtmlDecode(video.Views);

                ListViewItem item = new ListViewItem(decodedTitle);
                item.SubItems.Add(video.VideoId);
                item.SubItems.Add(decodedChannel);
                item.SubItems.Add(decodedViews);

                item.Tag = video.ThumbnailUrl;

                resultsLV.Items.Add(item);
            }
        }

        private void resultsLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultsLV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = resultsLV.SelectedItems[0];

                string selectedTitle = selectedItem.SubItems[0].Text;
                string selectedVideoId = selectedItem.SubItems[1].Text;
                string selectedChannel = selectedItem.SubItems[2].Text;
                string selectedViews = selectedItem.SubItems[3].Text;

                string selectedThumbnail = selectedItem.Tag as string;

                MasterForm masterForm = (MasterForm)Application.OpenForms["MasterForm"];
                if (masterForm != null)
                {
                    masterForm.videoTitleLbl.Text = selectedTitle;
                    masterForm.videoIdLbl.Text = "Video ID: " + selectedVideoId;
                    masterForm.channelLbl.Text = "Channel: " + selectedChannel;
                    masterForm.viewCountLbl.Text = "Views: " + selectedViews;

                    if (!string.IsNullOrEmpty(selectedThumbnail))
                    {
                        masterForm.thumbnailPB.Image = LoadImageFromUrl(selectedThumbnail);
                    }

                    Properties.Settings.Default.SelectedVideoId = selectedVideoId;

                    masterForm.downloadVideoBtn.Enabled = true;
                    masterForm.copyVideoIdBtn.Enabled = true;
                }
            }

            // Congrats my friend, you've successfully walked through hell. Now you gotta walk back...
        }
    }
}
