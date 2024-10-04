using System.Runtime.InteropServices;
using Tyuiu.EvseevEI.Sprint1.Task5.V2.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 33;
            DataService ds = new DataService();
            double res = ds.FahrenheitTo—elsius(x);

            int result = Convert.ToInt32(res);
            Assert.AreEqual(1, result);

        }
    }
}
