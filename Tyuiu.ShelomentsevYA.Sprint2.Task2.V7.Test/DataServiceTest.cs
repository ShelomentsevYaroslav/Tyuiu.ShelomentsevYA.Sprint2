
using Tyuiu.ShelomentsevYA.Sprint2.Task2.V7.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            
            bool result = ds.CheckDotInShadedArea(5, 5);
            Assert.AreEqual(true, result);

            
            
        }
    }
}
