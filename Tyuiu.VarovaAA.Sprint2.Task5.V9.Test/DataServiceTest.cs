using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint2.Task5.V9.Lib;
namespace Tyuiu.VarovaAA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindNextDate()
        {
            DataService ds = new DataService();

            Assert.AreEqual(2603, ds.FindDateOfNextDay(25, 3));
            Assert.AreEqual(103, ds.FindDateOfNextDay(28, 2));
        }
    }
}
