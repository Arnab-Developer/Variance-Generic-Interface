using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface ISetData<in T>
    {
        T MyValue { set; }
    }
}
