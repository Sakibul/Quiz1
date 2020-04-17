using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    public static class MyIntegerExtension
    {
        public static bool IsDivisibleBy3(this int i)
        {
            return ((i % 3) == 0);
        }
    }
}