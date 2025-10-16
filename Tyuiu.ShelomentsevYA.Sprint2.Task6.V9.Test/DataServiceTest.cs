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

            Assert.AreEqual("2.1", ds.FindDateOfNextDay(1, 1));
            Assert.AreEqual("1.2", ds.FindDateOfNextDay(1, 31));
            Assert.AreEqual("1.3", ds.FindDateOfNextDay(2, 28));
            Assert.AreEqual("1.5", ds.FindDateOfNextDay(4, 30));
            Assert.AreEqual("1.1", ds.FindDateOfNextDay(12, 31));
        }
    }
}
