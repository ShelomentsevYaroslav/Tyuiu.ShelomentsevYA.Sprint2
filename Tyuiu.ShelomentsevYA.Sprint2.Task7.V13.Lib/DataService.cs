using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShelomentsevYA.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool insideCircle = (x * x + y * y) <= 1;

            
            bool belowLine1 = y <= 1;

            
            bool aboveLine2 = y >= x - 1;

            
            return insideCircle && belowLine1 && aboveLine2;
        }
    }
}
