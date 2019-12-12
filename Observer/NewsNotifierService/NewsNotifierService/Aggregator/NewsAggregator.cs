using System;
using System.Collections.Generic;


namespace NewsNotifierService.Aggregator
{
    public class NewsEventArgs
    {
        public string Twitter { get; private set; }
        public string Vk { get; private set; }

        public NewsEventArgs(string twitter, string vk)
        {
            Twitter = twitter;
            Vk = vk;
        }
    }

    public delegate void NewsChangeEventHandler(object sender, NewsEventArgs e);

    public class NewsAggregator
    {
        private readonly Random _random;
        public event NewsChangeEventHandler NewsChanged;
        public NewsAggregator()
        {
            _random = new Random();
        }

        public void NotifyObservers()
        {
            var twitterNews = GetTwitter();
            var vkNews = GetVk();
            NewsChanged?.Invoke(this, new NewsEventArgs(twitterNews, vkNews));
        }

        private string GetTwitter()
        {
            var news = new List<string>
            {
                "news from twitter 1",
                "news from twitter 2",
                "news from twitter 3",
                "news from twitter 4",
            };
            return news[_random.Next(4)];
        }

        private string GetVk()
        {
            var news = new List<string>
            {
                "news from vk 1",
                "news from vk 2",
                "news from vk 3",
                "news from vk 4",
            };
            return news[_random.Next(4)];
        }

        public void NewNewsAvailable()
        {
            NotifyObservers();
        }
    }
}
