using System;
using System.Collections.Generic;
using System.Text;

namespace laba_5
{
    interface IMyNumber <T> where T : IMyNumber<T>
    {
        T Add(T b);
        T Subtract(T b);
        T Multiply(T b);
        T Divide(T b);
    }
}
