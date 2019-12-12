using System;
using NewsNotifierService.Aggregator;
using NewsNotifierService.Widgets;

namespace NewsNotifierService
{
    internal class Program
    {
        static void Main()
        {
            var aggregator = new NewsAggregator();
            var twitter = new TwitterObserver();
            var vk = new VkObserver();

            aggregator.NewsChanged += twitter.Update;
            aggregator.NewsChanged += vk.Update;
            aggregator.NewNewsAvailable();

            Console.WriteLine("--------------");

            aggregator.NewNewsAvailable();
            aggregator.NewsChanged -= vk.Update;
            Console.WriteLine("--------------");
            aggregator.NewNewsAvailable();


            Console.ReadLine();
        }
    }
}
