using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewsNotifierService.Widgets;

namespace NewsNotifierService
{
    public class NewsAggregator
    {

        private List<IWidget> _widgets;


        public NewsAggregator()
        {
            _widgets = new List<IWidget>();

        }

        public void RegistedWidget(IWidget newWidget)
        {
            _widgets.Add(newWidget);
        }

        public bool UnregisterWidget(IWidget widgetToRemove)
        {
            return _widgets.Remove(widgetToRemove);
        }
        

        public void NotifyWidgets()
        {
            foreach (var w in _widgets)
            {
                w.Update("a", "b");
            }
        }
    }
}
