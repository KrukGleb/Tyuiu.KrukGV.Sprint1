using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KrukGV.Sprint1.Task7.V5.Lib
{
    public class DataService : ISprint1Task7V5
    {
        public double Calculate(double x)
        {
            var x1 = Math.Log(Math.Abs(Math.Cos(x)));
            var x2 = Math.Log(1 + x * x);
            return Math.Round(x1/x2, 3);
        }
    }
}