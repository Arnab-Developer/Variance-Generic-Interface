using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface IGetData<out T>
    {
        T MyValue { get; }
    }
}
