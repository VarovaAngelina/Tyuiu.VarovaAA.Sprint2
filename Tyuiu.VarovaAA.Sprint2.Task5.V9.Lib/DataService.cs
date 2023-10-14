using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VarovaAA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public int FindDateOfNextDay(int n, int m)
        {
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (n == 31)
                    {
                        n = 1;
                        m += 1;
                        break;
                    }
                    else
                    {
                        n += 1;
                        break;
                    }
                case 2:
                    if (n == 28)
                    {
                        n = 1;
                        m += 1;
                        break;
                    }
                    else
                    {
                        n += 1;
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    if (n == 30)
                    {
                        n = 1;
                        m += 1;
                        break;
                    }
                    else
                    {
                        n += 1;
                        break;
                    }
                case 12:
                    if (n == 31)
                    {
                        break;
                    }
                    else
                    {
                        n += 1;
                        break;
                    }
            }

            string t;
            string k;
            if (n < 10)
            {
                t = "0" + n.ToString();
            }
            else
            {
                t = n.ToString();
            }

            if (m < 10)
            {
                k = "0" + m.ToString();
            }
            else
            {
                k = m.ToString();
            }

            return int.Parse(t + k);
        }
    }
}
