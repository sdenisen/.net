using System;
using DuckApps.Controllers;
using DuckApps.Interfaces;

namespace DuckApps.Ducks
{
    public class BaseDuck
    {
        protected IFlyable FlyAction;
        protected IQuackable QuackAction;

        protected BaseDuck()
        {
            FlyAction = new SimpleFlyAction();
            QuackAction = new SimpleQuackAction();
        }

        public void Swim()
        {
            Console.WriteLine("I'm swiming");
        }

        public void Fly()
        {
            FlyAction.Fly();
        }

        public void Quack()
        {
            QuackAction.Quack();
        }

        public virtual void Show(){}
    }
}
