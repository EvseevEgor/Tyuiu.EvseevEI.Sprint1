using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.EvseevEI.Sprint1.Task2.V19.Lib
{
    public class DataService : ISprint1Task2V19
    {
        public double ConvertInchToKm(int value)
        {
            double result = Math.Round((2.54 * value) / 100,3);
            return result;

        }
    }
}
