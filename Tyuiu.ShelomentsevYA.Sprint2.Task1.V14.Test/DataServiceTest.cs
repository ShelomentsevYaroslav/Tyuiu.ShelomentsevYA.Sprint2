
using Tyuiu.ShelomentsevYA.Sprint2.Task1.V14.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 185;
            int b = 216;
            int c = 174;
            int d = 917;

            bool[] expected = { false, true, true, true, true, false };

            DataService ds = new DataService();
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
