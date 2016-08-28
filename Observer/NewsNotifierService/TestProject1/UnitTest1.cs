using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewsNotifierService;
using NewsNotifierService.Widgets;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NotifyTwitter()
        {
            var aggregator = new NewsAggregator();
            var twitter = new TwitterWidget();

            aggregator.RegistedWidget(twitter);

            aggregator.NotifyWidgets();
            aggregator.UnregisterWidget(twitter);

            twitter.Display();
        }
    }
}
