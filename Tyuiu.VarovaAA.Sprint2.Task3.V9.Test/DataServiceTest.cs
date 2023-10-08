using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint2.Task3.V9.Lib;
namespace Tyuiu.VarovaAA.Sprint2.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = -2.667;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 0.2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -14;
            double res = ds.Calculate(x);
            double wait = -154.071;
            Assert.AreEqual(wait, res);
        }
    }
}
