using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using DuckApps.Ducks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDuckApps
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckWoodenDuck()
        {
            var wd = new WoodenDuck();
            wd.Show();
            wd.Fly();
            wd.Quack();
            wd.Swim();
        }

        [TestMethod]
        public void CheckRubberDuck()
        {
            var wd = new RubberDuck();
            wd.Show();
            wd.Fly();
            wd.Quack();
            wd.Swim();
        }
        
        [TestMethod]
        public void CheckSimpleDuck()
        {
            var wd = new SimpleDuck();
            wd.Show();
            wd.Fly();
            wd.Quack();
            wd.Swim();
        }
        
        [TestMethod]
        public void CheckExoticDuck()
        {
            var wd = new ExoticDuck();
            wd.Show();
            wd.Fly();
            wd.Quack();
            wd.Swim();
        }
    }
}
