using Tyuiu.EvseevEI.Sprint1.Task3.V18.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Евсеев Е.И. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                                       *");
            Console.WriteLine("* Темa: Операторы составного исполнения                                                                   *");
            Console.WriteLine("* Задание #3                                                                                                                       *");
            Console.WriteLine("* Вариант #18                                                                                                                    *");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПБ-24-2                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,      *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                               *");
            Console.WriteLine("*                                                                                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение х");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите значение z");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Количество квадратов поместившихся в прямоугольник ="+ ds.HowManySquares(x,y,z));
            Console.ReadKey();


        }
    }
}
