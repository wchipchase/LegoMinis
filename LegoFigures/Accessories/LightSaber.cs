using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Accessories
{
    class LightSaber
    {
        public int Length { get; set; }
        public string Color { get; set; }
        
        public LightSaber(int length, string color)
        {
            Length = length;
            Color = color;
        }

        public void Slice()
        {
            Console.WriteLine("I'm chopping ur head");
        }
    }
}
