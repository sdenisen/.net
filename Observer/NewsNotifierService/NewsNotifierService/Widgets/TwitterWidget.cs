using System;

namespace NewsNotifierService.Widgets
{
    public class TwitterWidget : IWidget
    {
        private string _tweet;
        public void Update(string twitter, string email)
        {
            _tweet = twitter;
        }

        public void Display()
        {
            Console.WriteLine(_tweet);
        }
    }
}
