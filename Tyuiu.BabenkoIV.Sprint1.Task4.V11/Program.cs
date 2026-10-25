using Tyuiu.BabenkoIV.Sprint1.Task4.V11.Lib;
namespace Tyuiu.BabenkoIV.Sprint1.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Резултат " + ds.Calculate(x, y));
        }
    }
}
