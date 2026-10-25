using Tyuiu.BabenkoIV.Sprint1.Task5.V6.Lib;
namespace Tyuiu.BabenkoIV.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int k;
            Console.WriteLine("Введите день невисокосного года");
            k = Convert.ToInt32(Console.ReadLine());
            var res = ds.Calculate(k);
            Console.WriteLine($"День недели: {res}");
        }
    }
}
