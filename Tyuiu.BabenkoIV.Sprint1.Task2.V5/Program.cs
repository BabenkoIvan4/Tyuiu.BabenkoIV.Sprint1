using Tyuiu.BabenkoIV.Sprint1.Task2.V5.Lib;
namespace Tyuiu.BabenkoIV.Sprint1.Task2.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x;
            Console.WriteLine("Введите строну куба");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("площадь поверхности куба " + ds.CalculateSideSquare(x));
            Console.ReadLine();

        }
    }
}
