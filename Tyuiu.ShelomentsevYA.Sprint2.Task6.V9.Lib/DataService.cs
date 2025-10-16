using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int daysInMonth = 0;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = 28;
                    break;
            }

            int nextDay = n + 1;
            int nextMonth = m;

            if (nextDay > daysInMonth)
            {
                nextDay = 1;
                nextMonth++;
            }

            if (nextMonth > 12)
            {
                nextMonth = 1;
            }

            return $"{nextDay:D2}.{nextMonth:D2}";
        }
    }
}
