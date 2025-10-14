using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task0.V8.Lib
{
    public class DataService : ISprint2Task0V8
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];


            result[0] = (x + 66) == y;    
            result[1] = (x + 66) != y;    
            result[2] = (x - 100) < y;   
            result[3] = (x + 50) > y;    
            result[4] = (x + 50) <= y;    
            result[5] = (x + 60) >= y;    

            return result;
        }
    }
}
