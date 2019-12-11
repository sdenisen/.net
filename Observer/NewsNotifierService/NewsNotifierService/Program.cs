using System;
using NewsNotifierService.Aggregator;
using NewsNotifierService.Widgets;

namespace NewsNotifierService
{
    class Program
    {
        static void Main()
        {
            NewsAggregator aggregator = new NewsAggregator();
            TwitterObserver _twitter = new TwitterObserver();
            VkObserver _vk = new VkObserver();

            aggregator.RegisterObserver(_twitter);
            aggregator.RegisterObserver(_vk);

            aggregator.NewNewsAvailable();
            Console.WriteLine("--------------");
            aggregator.NewNewsAvailable();
            Console.WriteLine("--------------");
            aggregator.NewNewsAvailable();


            Console.ReadLine();
        }
    }
}
