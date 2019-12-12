using System;
using NewsNotifierService.Aggregator;

namespace NewsNotifierService.Widgets
{
    class VkObserver : IObserver, IWidget
    {
        private string _vk;

        public void Update(object obj, NewsEventArgs news)
        {
            _vk = news.Vk;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("vk info: " + _vk);
        }
    }
}
