using Tyuiu.BabenkoIV.Sprint1.Task7.V13.Lib;
namespace Tyuiu.BabenkoIV.Sprint1.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x,y;
            Console.WriteLine("Введите x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат:" + ds.Calculate(x,y));
        }
    }
}
