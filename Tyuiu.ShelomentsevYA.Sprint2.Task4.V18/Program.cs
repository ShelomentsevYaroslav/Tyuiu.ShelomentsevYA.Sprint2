using System.ComponentModel;
using Tyuiu.ShelomentsevYA.Sprint2.Task4.V18.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint2.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Шеломенцев Я. А. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Шеломенцев Ярослав Александрович | ИСТНб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение c использовани *");
            Console.WriteLine("* ем тернарного оператора, где пользователь вводит значение переменных    *");
            Console.WriteLine("* X, Y с клавиатуры                                                       *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой;             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ВХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double z;
            z = ds.Calculate(x, y);
            Console.WriteLine(z);
            Console.ReadLine();

        }
    }
}
