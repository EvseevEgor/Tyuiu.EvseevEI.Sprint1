using Tyuiu.EvseevEI.Sprint1.Task1.V9.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Евсеев Е.И. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                                       *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                                         *");
            Console.WriteLine("* Задание #1                                                                                                                      *");
            Console.WriteLine("* Вариант #9                                                                                                                     *");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПБ-24-2                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,      *");
            Console.WriteLine("*вычисляет результат по формуле (1 + 3 * x) / (4 * y) и печатает его на экране.        *");
            Console.WriteLine("*                                                                                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РEЗУЛЬТАТ:                                                                                                                  *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
