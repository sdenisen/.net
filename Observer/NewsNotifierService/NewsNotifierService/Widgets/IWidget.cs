using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsNotifierService.Widgets
{
    public interface IWidget
    {
        void Update(string twitter, string email);
    }
}
