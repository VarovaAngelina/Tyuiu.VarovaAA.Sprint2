using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VarovaAA.Sprint2.Task6.V14.Lib;
namespace Tyuiu.VarovaAA.Sprint2.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Варова А. А. | ИИПб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Варова Ангелина Александровна | ИИПб-23-2                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Условие: Дано целое число k(1 <= k <= 365).Определить, каким днем       *");
            Console.WriteLine("* недели(понедельником, вторником, …, субботой или воскресеньем) является *");
            Console.WriteLine("* k - й день не високосного года, в котором 1 января d - й день недели    *");
            Console.WriteLine("* (если 1 января — понедельник, то d = 1, если вторник — d = 2, …, если   *");
            Console.WriteLine("* воскресенье — d = 7).                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите целое число от 1 до 365: ");
            double k = Convert.ToDouble(Console.ReadLine());

            string res;
            double d;

            if ((k < 1) || (k > 365))
            {
                res = " Введенно неверное значение!";
            }
            else
            {
                d = k % 7;
                res = " Это день: " + ds.FindDayName(Convert.ToInt32(d));
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
