using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contravariant.
            ISetData<string> set;
            set = new Demo<object>();

            // Covariant.
            IGetData<object> get;
            get = new Demo<string>();
        }
    }
}
