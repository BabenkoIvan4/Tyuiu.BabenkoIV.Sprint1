using Tyuiu.BabenkoIV.Sprint1.Task5.V6.Lib;
namespace Tyuiu.BabenkoIV.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService(); 
            int x = 8;
            var res = dataService.Calculate(x);
            Assert.AreEqual(1, res);
        }
    }
}
