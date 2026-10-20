
using Tyuiu.KrukGV.Sprint1.Task3.V6.Lib;

namespace Tyuiu.KrukGV.Sprint1.Task3.V6
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Крук Глеб Владиславович | НТм25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу   *");
            Console.WriteLine("* (туда и обратно). расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите расстояние до дачи (км)");
            var s_str = Console.ReadLine();
            
            if (s_str is null)
            {
                Console.WriteLine("Введите нормально в следующий раз\n");
                return;
            }
            s_str = s_str.Replace(".", ",");
            var s = Convert.ToDouble(s_str);

            Console.WriteLine("Введите количество бензина, которое потребляет автомобиль на 100 км пробега");
            var o_str = Console.ReadLine();
            if (o_str is null)
            {
                Console.WriteLine("Введите нормально в следующий раз\n");
                return;
            }
            o_str = o_str.Replace(".", ",");
            var o = Convert.ToDouble(o_str);

            Console.WriteLine("Введите цену одного литра ");
            var p_str = Console.ReadLine();
            if (p_str is null)
            {
                Console.WriteLine("Введите нормально в следующий раз\n");
                return;
            }
            p_str = p_str.Replace(".", ",");
            var p = Convert.ToDouble(p_str);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.TravelCost(s, o, p));

            Console.Read();
        }
    }
}