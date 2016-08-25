using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckApps.Interfaces;

namespace DuckApps.Controllers
{
    class SimpleFlyAction : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flyAction with my wings");
        }
    }
}
