using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Room
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return $"{Number}: {Nome}, {Email}";
        }

    }
}
