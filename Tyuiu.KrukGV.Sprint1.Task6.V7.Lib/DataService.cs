using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KrukGV.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string[] words = value.Split(' ');
            var res = "";
            foreach (var word in words) 
            {
                var w = word.Substring(0, word.Length - 1);
                res += w + " ";
            }
            res = res.Substring(0, res.Length - 1);
            return res;
        }
    }
}