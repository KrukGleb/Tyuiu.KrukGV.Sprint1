using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KrukGV.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {

        public double TravelCost(double distance, double gasFlow, double gasPrice)
        {
            var x = 2 * distance / 100 * gasFlow * gasPrice;
            // так 2 или 3??
            x = Math.Round(x, 2, MidpointRounding.AwayFromZero);
            return x;
        }
    }
}