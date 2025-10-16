using System;
using Tyuiu.ShelomentsevYA.Sprint2.Task6.V9.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Шеломенцев Я. А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Шеломенцев Ярослав Александрович | ИСТНб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По введённой дате (число и номер месяца) определить дату следующего дня *");
            Console.WriteLine("* (принять, что введённая дата не 31 декабря).                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int n, m;

            Console.Write("Введите число (n): ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер месяца (m): ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.GetNextDate(n, m);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
