using Tyuiu.KrukGV.Sprint1.Task2.V8.Lib;

namespace Tyuiu.KrukGV.Sprint1.Task2.V8
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Крук Глеб Владиславович | НТм25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
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
            var x = Convert.ToInt32(x_str);

            Console.WriteLine("Введите y");
            var y_str = Console.ReadLine();
            if (y_str is null)
            {
                Console.WriteLine("Введите нормально в следующий раз\n");
                return;
            }
            var y = Convert.ToInt32(y_str);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CalculatePerimetr(x, y));

            Console.Read();
        }
    }
}