using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Demo<T> : IGetData<T>, ISetData<T>
    {
        private T _myValue;

        T IGetData<T>.MyValue
        {
            get { return _myValue; }
        }

        T ISetData<T>.MyValue
        {
            set { _myValue = value; }
        }
    }
}
