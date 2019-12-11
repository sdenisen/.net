using System;
using System.Collections.Generic;
using NewsNotifierService.Widgets;


namespace NewsNotifierService.Aggregator
{
    public class NewsAggregator: ISubject
    {

        private readonly List<IObserver> _widgets;
        private readonly Random _random;
        
        public NewsAggregator()
        {
            _widgets = new List<IObserver>();
            _random = new Random();
        }
        
        public void RegisterObserver(IObserver observerToRegister)
        {
            _widgets.Add(observerToRegister);
        }

        public bool ReleaseObserver(IObserver observerToRelease)
        {
            return _widgets.Remove(observerToRelease);
        }

        public void NotifyObservers()
        {
            var twitterNews = GetTwitter();
            var vkNews = GetVk();

            foreach (var w in _widgets)
            {
                w.Update(twitterNews, vkNews);
            }
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
