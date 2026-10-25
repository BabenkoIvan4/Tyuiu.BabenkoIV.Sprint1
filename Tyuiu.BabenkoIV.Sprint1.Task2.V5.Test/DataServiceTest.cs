using Tyuiu.BabenkoIV.Sprint1.Task2.V5.Lib;
namespace Tyuiu.BabenkoIV.Sprint1.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            var res = ds.CalculateSideSquare(a);
            Assert.AreEqual(24, res);
        }
    }
}
