using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckApps.Controllers;

namespace DuckApps.Ducks
{
    public class WoodenDuck : BaseDuck
    {
        public WoodenDuck()
        {
            FlyAction = new WoodenFlyAction();
            QuackAction = new WoodenQuackAction();
        }

        public override void Show()
        {
            Console.WriteLine("It's me, wooden duck");
        }
    }
}
