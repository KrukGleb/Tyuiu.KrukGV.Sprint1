using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KrukGV.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            var res = x - Math.Truncate(x);
            res *= 10;

            var ans = Convert.ToInt32(Math.Truncate(res));
            return ans;
        }

    }
}