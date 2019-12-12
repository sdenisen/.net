using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewsNotifierService.Aggregator;

namespace NewsNotifierService.Widgets
{
    public interface IObserver
    {
        void Update(object obj, NewsEventArgs news);
       
    }
}
