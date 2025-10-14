using System.ComponentModel;
using Tyuiu.ShelomentsevYA.Sprint2.Task2.V7.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint2.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Шеломенцев Я. А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Шеломенцев Ярослав Александрович | ИСТНб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в                     *");
            Console.WriteLine("* заштрихованной области.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ВХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("***************************************************************************");

            int x, y;
            Console.WriteLine("Введите значение X:");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
