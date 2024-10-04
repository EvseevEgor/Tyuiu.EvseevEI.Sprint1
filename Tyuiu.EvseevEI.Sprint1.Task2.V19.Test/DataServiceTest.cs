using Tyuiu.EvseevEI.Sprint1.Task2.V19.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(254, ds.ConvertInchToKm(10000));
            
        }
    }
}