using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VarovaAA.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // a = 415, b = 616, c = 134, d = 127 (True, False, False, False, False, True)
            bool[] res = new bool[6];

            res[0] = (a < b) | (c < d);
            res[1] = (a + 2 > b) & (c < d);
            res[2] = (a > b) || (c > d * 5);
            res[3] = (a > b * 2) && (c < d);
            res[4] = !res[0];
            res[5] = (a + 2 > b) ^ (c > d);

            return res;
        }
    }
}
