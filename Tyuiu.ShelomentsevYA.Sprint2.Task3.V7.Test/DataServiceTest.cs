using Tyuiu.ShelomentsevYA.Sprint2.Task3.V7.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task3.VX.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFunctionValues()
        {
            DataService ds = new DataService();

           
            Assert.AreEqual(Math.Round(2 * Math.Pow((Math.Pow(2, 2) + 1) / (2 - 1), 2), 3), ds.Calculate(2));  
            Assert.AreEqual(Math.Round((Math.Pow(0, 2) - Math.Cos(Math.Pow(0, 2)) + 10) / (Math.Pow(0, 2) - Math.Sin(Math.Pow(0, 2)) + 12), 3), ds.Calculate(0));
            Assert.AreEqual(Math.Round(Math.Pow((7 + 1 / Math.Pow(-2, 2)), 2), 3), ds.Calculate(-2));          
            Assert.AreEqual(20736.25, ds.Calculate(-12));                   
        }
    }
}
