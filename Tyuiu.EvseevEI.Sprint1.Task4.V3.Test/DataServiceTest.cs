using Tyuiu.EvseevEI.Sprint1.Task4.V3.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds= new DataService();
            double x = 3;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);

        }
    }
}