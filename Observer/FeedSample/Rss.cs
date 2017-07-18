using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.FeedSample
{
    public class Rss
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Uri Url { get; set; }

        public Rss(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public Rss(string title, string description, Uri url)
        {
            
        }

        public void SetUrl(string url)
        {
            this.Url = new Uri(url);
        }
    }
}
