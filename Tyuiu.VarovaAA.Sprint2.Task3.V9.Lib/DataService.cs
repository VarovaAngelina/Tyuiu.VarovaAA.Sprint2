using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VarovaAA.Sprint2.Task3.V9.Lib
{
    public class DataService : ISprint2Task3V9
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = Math.Round((x * Math.Pow(((x + 15) / (x - 7)), x)), 3);
            }
            else
            {
                if (x == 0)
                {
                    y = Math.Round(((Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x))), 3);
                    // y = (sinx + cosx)/(cosx - sinx)
                }
                else
                {
                    if ((x > -13) && (x < 0))
                    {
                        y = Math.Round(Math.Pow((1 + 4 / Math.Pow(x, 2)), x), 3);
                        // y = (1 + 4/x^2)^x
                    }
                    else
                    {
                        if (x < -13)
                        {
                            y = Math.Round((x + 10 * x + (1 / x)), 3);
                            // y = x + 10 * x + (1/x)
                        }
                    }
                }
            }

            return y;
        }
    }
}
