using System;
using Tyuiu.ShelomentsevYA.Sprint2.Task5.V4.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Шеломенцев Я. А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Шеломенцев Ярослав Александрович | ИСТНб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастям карт присвоены номера:                                           *");
            Console.WriteLine("* 1 — пики, 2 — трефы, 3 — бубны, 4 — червы.                              *");
            Console.WriteLine("* По введённому номеру масти m (1 <= m <= 4) определить её название.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int m;
            Console.Write("Введите номер масти (1–4): ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindCardSuit(m);
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
