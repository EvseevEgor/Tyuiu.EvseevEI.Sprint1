using Tyuiu.EvseevEI.Sprint1.Task6.V6.Lib;
namespace Tyuiu.EvseevEI.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "xaxa xoxo";
            DataService ds = new DataService();
            string res = ds.DeleteFirstLetter(strTest);
            Assert.AreEqual("axa oxo" , res);
        }
    }
}