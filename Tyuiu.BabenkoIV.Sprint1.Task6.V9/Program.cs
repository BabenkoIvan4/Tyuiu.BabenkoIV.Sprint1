using Tyuiu.BabenkoIV.Sprint1.Task6.V9.Lib;
namespace Tyuiu.BabenkoIV.Sprint1.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string s;
            s = Convert.ToString(Console.ReadLine());
            Console.WriteLine(ds.MoveLetterToStart(s));
        }
    }
}
