using Tyuiu.EvseevEI.Sprint1.Task4.V3.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task4.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Евсеев Е.И. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                                       *");
            Console.WriteLine("* Темa: Class Math                                                                                                             *");
            Console.WriteLine("* Задание #4                                                                                                                      *");
            Console.WriteLine("* Вариант #3                                                                                                                     *");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПБ-24-2                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                    *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу: Дано значение             *");
            Console.WriteLine("* температуры в градусах Фаренгейта. Определить значение этой же температуры*");
            Console.WriteLine("*  в градусах Цельсия. Ответ привести к целому с помощью класса Convert.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("***************************************************************************");
            int x, y;
            Console.WriteLine("Введите значение х");
             x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y");
             y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                  *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.Calculate(x, y));         Console.ReadKey();




        }
    }
}
