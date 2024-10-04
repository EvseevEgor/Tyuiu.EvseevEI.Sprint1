using Tyuiu.EvseevEI.Sprint1.Task1.V9.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1,res);

        }
    }
}