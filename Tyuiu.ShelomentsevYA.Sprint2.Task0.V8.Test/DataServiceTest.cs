using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShelomentsevYA.Sprint2.Task0.V8.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 185;
            int y = 251;

            bool[] expected = { true, false, true, false, true, false };

            DataService ds = new DataService();
            bool[] result = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
