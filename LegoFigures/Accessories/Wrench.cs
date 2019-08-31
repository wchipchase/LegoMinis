using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Accessories
{
    class Wrench
    {
        public int Length { get; set; }
        public string Color { get; set; }

        public Wrench(int length, string color)
        {
            Length = length;
            Color = color;
        }

        public void Tighten()
        {
            Console.WriteLine("I'm tightening mah nuts");
        }
    }
}
