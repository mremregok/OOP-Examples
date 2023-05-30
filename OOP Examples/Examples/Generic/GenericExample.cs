using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Examples.Examples.Generic
{
    internal class GenericExample
    {
        public static Type GetType<T>()
        {
            return typeof(T);
        }

        private static readonly object _lockObj;
    }
}
