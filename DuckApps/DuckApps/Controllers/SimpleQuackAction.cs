using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckApps.Interfaces;

namespace DuckApps.Controllers
{
    class SimpleQuackAction : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("quackAction, quackAction...");
        }
    }
}
