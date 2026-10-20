using Tyuiu.KrukGV.Sprint1.Task1.V5.Lib;

namespace Tyuiu.KrukGV.Sprint1.Task1.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Крук Г. В. | НТм25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Крук Глеб Владиславович | НТм25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение  (5+(x*y/3))            *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");            

            Console.WriteLine("Введите x");
            var x_str = Console.ReadLine();
            if (x_str is null)
            {
                Console.WriteLine("Введите нормально в следующий раз\n");
                return;
            }

            x_str = x_str.Replace(".", ",");
            var x = Convert.ToDouble(x_str);

            Console.WriteLine("Введите y\n");
            var y_str = Console.ReadLine();
            if (y_str is null)
            {
                Console.WriteLine("Введите нормально в следующий раз\n");
                return;
            }
            y_str = y_str.Replace(".", ",");
            var y = Convert.ToDouble(y_str);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));


            Console.Read();
        }
    }
}