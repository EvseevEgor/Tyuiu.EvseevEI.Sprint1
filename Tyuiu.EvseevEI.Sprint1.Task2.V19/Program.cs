using System.Runtime.InteropServices;
using Tyuiu.EvseevEI.Sprint1.Task2.V19.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Евсеев Е.И. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                                       *");
            Console.WriteLine("* Темa: Арифметические операторы в C#                                                                      *");
            Console.WriteLine("* Задание #2                                                                                                                       *");
            Console.WriteLine("* Вариант #19                                                                                                                    *");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПБ-24-2                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,      *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                               *");
            Console.WriteLine("*                                                                                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Х в метрах --- " + ds.ConvertInchToKm(x));

            Console.ReadLine();



        }
    }
}
