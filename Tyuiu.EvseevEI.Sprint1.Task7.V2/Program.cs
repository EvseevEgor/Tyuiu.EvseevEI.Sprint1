using Tyuiu.EvseevEI.Sprint1.Task7.V2.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Евсеев Е.И. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                                       *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                                           *");
            Console.WriteLine("* Задание #7                                                                                                                      *");
            Console.WriteLine("* Вариант #2                                                                                                                     *");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПБ-24-2                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                    *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                                           *");
            Console.WriteLine("*                                                                                                                                         *");
            Console.WriteLine("*                                                                                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*         sin x + cos y                                                                                                            *");
            Console.WriteLine("* z= --------------------- * tg xy                                                                                            *");
            Console.WriteLine("*          cos x - sin y                                                                                                            *");

            double x, y;
            Console.WriteLine("Введите значение Х:");
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                  *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
