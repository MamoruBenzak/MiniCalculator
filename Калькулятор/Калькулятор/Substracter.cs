using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
   public class Substracter
    {
        public string Calculate (double first, double second)
        {
            double res = first - second;
            return res.ToString();
        }
    }
}
