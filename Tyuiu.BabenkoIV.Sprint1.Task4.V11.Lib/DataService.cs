using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BabenkoIV.Sprint1.Task4.V11.Lib
{
    public class DataService : ISprint1Task4V11
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Atan(x) / Math.Exp(y),3);
        }
    }
}
