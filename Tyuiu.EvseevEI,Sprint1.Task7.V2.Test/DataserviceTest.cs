using Tyuiu.EvseevEI.Sprint1.Task7.V2.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataserviceTest
    {
        [TestMethod]
        public void ValidExpression()
       {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0, res);
        }
    }
}