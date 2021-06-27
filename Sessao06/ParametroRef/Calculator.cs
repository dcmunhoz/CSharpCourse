using System;
using System.Collections.Generic;
using System.Text;

namespace ParametroRef
{
    class Calculator
    {
        public static int Triple(ref int x)
        {
            return x = x * 3;
        }
    }
}
