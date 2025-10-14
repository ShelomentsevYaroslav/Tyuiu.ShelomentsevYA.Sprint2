using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task2.V7.Lib
{
    public class DataService : ISprint2Task2V7
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            
            if ((y >= 3 && y <= 6) && (x >= 3 && x <= 7)) return true;
            if ((y >= 3 && y <= 6) && (x >= 9 && x <= 13)) return true;

            
            if ((y == 7) && (x >= 3 && x <= 13)) return true;

            
            if ((y >= 8 && y <= 11) && (x >= 9 && x <= 13)) return true;

            
            if ((y >= 12 && y <= 13) && (x >= 3 && x <= 5)) return true;
            if ((y >= 12 && y <= 13) && (x >= 9 && x <= 11)) return true;

            return false;
        }
    }
}
