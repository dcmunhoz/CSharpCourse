﻿using System;
using System.Collections.Generic;
using System.Text;
using Exercicio2.Entities.Enums;

namespace Exercicio2.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
