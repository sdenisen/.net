using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsNotifierService.Widgets
{
    public interface IObserver
    {
        void Update(string twitter, string vk);
    }
}
