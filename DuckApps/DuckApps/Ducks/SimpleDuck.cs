using System;

namespace DuckApps.Ducks
{
    public class SimpleDuck : BaseDuck
    {
        public override void Show()
        {
            Console.WriteLine("It's me, simple duck");
        }
    }
}
