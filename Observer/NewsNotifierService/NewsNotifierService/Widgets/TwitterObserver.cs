using System;

namespace NewsNotifierService.Widgets
{
    public class TwitterObserver : IObserver
    {
        private string _tweet;        
        public void Update(string twitter, string vk)
        {
            _tweet = twitter;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("tweet info: " + _tweet);
        }

    }
}
