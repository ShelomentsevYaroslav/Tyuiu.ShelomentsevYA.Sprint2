using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint2.Task4.V18.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestTernaryOperation()
        {
            DataService ds = new DataService();

            
            double result1 = ds.Calculate(1, 6);   
            double expected1 = Math.Round(Math.Pow(6 + ((1 - 1) / Math.Pow(6, 3)), 1), 3);
            Assert.AreEqual(expected1, result1);

            
            double result2 = ds.Calculate(4, 5);   
            double expected2 = Math.Round(4 + 10 * 5 - (1 / 4.0), 3);
            Assert.AreEqual(expected2, result2);
        }
    }
}
