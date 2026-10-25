using Tyuiu.BabenkoIV.Sprint1.Task4.V11.Lib;
namespace Tyuiu.BabenkoIV.Sprint1.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.785, res);
        }
    }
}
