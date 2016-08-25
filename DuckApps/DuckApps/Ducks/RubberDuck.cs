using System;
using DuckApps.Controllers;

namespace DuckApps.Ducks
{
    public class RubberDuck : BaseDuck
    {
        public RubberDuck()
        {
            FlyAction = new RubberFlyAction();
            QuackAction = new RubberQuackAction();
        }

        public override void Show()
        {
            Console.WriteLine("It's me, rubber duck");
        }
    }
}
