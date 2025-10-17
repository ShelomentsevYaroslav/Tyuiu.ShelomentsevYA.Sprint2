using System;
using Tyuiu.ShelomentsevYA.Sprint2.Task7.V13.Lib;

namespace Tyuiu.ShelomentsevYA.Sprint2.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Шеломенцев Ярослав Александрович | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Геометрические вычисления с условными операторами                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить, находится ли точка с координатами (x, y) в заштрихованной   *");
            Console.WriteLine("* области,ограниченной окружностью x^2 + y^2 = 1, прямыми y = 1 и y = x-1 *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (result)
                Console.WriteLine("Точки находится в заштрихованной области.");
            else
                Console.WriteLine("Точки находится вне заштрихованной области.");

            Console.ReadKey();
        }
    }
}
