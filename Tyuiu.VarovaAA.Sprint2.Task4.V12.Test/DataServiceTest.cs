using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint2.Task4.V12.Lib;
namespace Tyuiu.VarovaAA.Sprint2.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = Math.Pow(9, 9);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 0.839;
            Assert.AreEqual(wait, res);
        }
    }
}
