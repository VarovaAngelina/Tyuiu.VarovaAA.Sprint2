using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint2.Task2.V15.Lib;
namespace Tyuiu.VarovaAA.Sprint2.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 8;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
