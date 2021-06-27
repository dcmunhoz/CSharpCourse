using System;
using System.Collections.Generic;
using System.Text;

namespace Structs
{
    struct Point
    {
        public double x, y;
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
