using Tyuiu.EvseevEI.Sprint1.Task6.V6.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Евсеев Е.И. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                                       *");
            Console.WriteLine("* Тема: Работа со строками класс String                                                                        *");
            Console.WriteLine("* Задание #6                                                                                                                      *");
            Console.WriteLine("* Вариант #6                                                                                                                     *");
            Console.WriteLine("* Выполнил: Евсеев Егор Игоревич | ИИПБ-24-2                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                    *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова, удалив   *");
            Console.WriteLine("* из них первую букву.                                                                                                     *");
            Console.WriteLine("*                                                                                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку;");
            string str =Convert.ToString (Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                  *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine(ds.DeleteFirstLetter(str));
            Console.ReadKey();
        }
    }
}
        
   