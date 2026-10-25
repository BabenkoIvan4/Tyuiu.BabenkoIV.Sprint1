using Tyuiu.BabenkoIV.Sprint1.Task3.V6.Lib;
namespace Tyuiu.BabenkoIV.Sprint1.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x, y, z;
            Console.WriteLine("Введите расстояние до дачи");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите расход бензина");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену литра бензина");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Поездка на дачу и обратно обойдется в " + ds.TravelCost(x, y, z));
            Console.ReadLine();
        }
    }
}
