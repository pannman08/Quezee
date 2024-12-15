using System;
using System.Collections.Generic;
using System.Text;

namespace Quezee
{
    public class Video
    {
        private string title;
        private string videoId;
        private string channel;
        private string views;
        private string length;
        private string thumbnailUrl;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string VideoId
        {
            get { return videoId; }
            set { videoId = value; }
        }

        public string Channel
        {
            get { return channel; }
            set { channel = value; }
        }

        public string Views
        {
            get { return views; }
            set { views = value; }
        }

        public string Length
        {
            get { return length; }
            set { length = value; }
        }

        public string ThumbnailUrl
        {
            get { return thumbnailUrl; }
            set { thumbnailUrl = value; }
        }
    }
}
