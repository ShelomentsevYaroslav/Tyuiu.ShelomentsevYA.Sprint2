using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task1.V14.Lib
{
    public class DataService : ISprint2Task1V14
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            
            result[0] = (a == b) | (c > d);         
            result[1] = (a < b) & (c < d);          
            result[2] = (a != b) || (c < d);        
            result[3] = (b > a) && (d > c);         
            result[4] = !(a > b) | (d > b);         
            result[5] = (a + c) >= (b + d);         

            return result;
        }
    }
}
