using Tyuiu.BabenkoIV.Sprint1.Task6.V9.Lib;
namespace Tyuiu.BabenkoIV.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string s = "МАМА и ПАПА";
            var res  = ds.MoveLetterToStart(s);
            string konch = "АМАМ и АПАП";
            Assert.AreEqual(konch, res);

        }
    }
}
