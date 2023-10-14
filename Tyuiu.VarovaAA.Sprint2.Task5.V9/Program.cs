using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VarovaAA.Sprint2.Task5.V9.Lib;
namespace Tyuiu.VarovaAA.Sprint2.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Варова А. А. | ИИПб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Варова Ангелина Александровна | ИИПб-23-2                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным n и m определить   *");
            Console.WriteLine("* дату следующего дня (принять, что n и m не характеризуют 31 декабря).   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            string res;
            string prres;
            int pr;
            int month;
            int date;

            if ((m < 1) || (m > 12))
            {
                res = " Введено неверное значение месяца!";
            }
            else
            {
                if ((n < 1) || (n > 31))
                {
                    res = " Введено неверное значение даты!";
                }
                else
                {
                    pr = ds.FindDateOfNextDay(n, m);
                    prres = pr.ToString();
                    if (prres.Length == 3)
                    {
                        res = prres[0] + "." + prres[1] + prres[2];
                    }
                    else
                    {
                        month = pr % 100;
                        date = pr / 100;
                        res = date.ToString() + "." + month.ToString();
                    }
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
