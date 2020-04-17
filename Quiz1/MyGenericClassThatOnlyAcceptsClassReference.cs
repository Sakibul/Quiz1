using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class MyGenericClassThatOnlyAcceptsClassReference<T> where T : class
    {
        public static void PrintTheParameter(T someObject)
        {
            Console.WriteLine(someObject);
        }
    }
}