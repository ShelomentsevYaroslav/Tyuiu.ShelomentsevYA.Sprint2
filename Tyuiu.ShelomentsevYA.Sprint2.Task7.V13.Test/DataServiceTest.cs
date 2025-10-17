
using Tyuiu.ShelomentsevYA.Sprint2.Task7.V13.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCheckDotInShadedArea()
        {
            DataService ds = new DataService();


            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0));         
            Assert.IsTrue(ds.CheckDotInShadedArea(-0.5, 0.5));   
            Assert.IsTrue(ds.CheckDotInShadedArea(0.8, 0.2));


            Assert.IsFalse(ds.CheckDotInShadedArea(1.1, 0));      
            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, 1.1));    
            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, -1));
        }
    }
}
