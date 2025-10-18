using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint2.Task6.V9.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("02.01", ds.FindDateOfNextDay(1, 1));
            Assert.AreEqual("01.02", ds.FindDateOfNextDay(1, 31));
            Assert.AreEqual("01.03", ds.FindDateOfNextDay(2, 28));
            Assert.AreEqual("01.05", ds.FindDateOfNextDay(4, 30));
            Assert.AreEqual("01.01", ds.FindDateOfNextDay(12, 31));
        }
    }
}
