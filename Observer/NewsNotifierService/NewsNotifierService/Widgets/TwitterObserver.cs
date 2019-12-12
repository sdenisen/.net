using System;
using NewsNotifierService.Aggregator;

namespace NewsNotifierService.Widgets
{
    public class TwitterObserver : IObserver, IWidget
    {
        private string _tweet;

        public void Update(object obj, NewsEventArgs news)
        {
            _tweet = news.Twitter;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("tweet info: " + _tweet);
        }
    }
}
