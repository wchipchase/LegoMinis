using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Accessories
{
    class Firehose
    {
        public int Length { get; set; }
        public string Color { get; set; }

        public Firehose(int length, string color)
        {
            Length = length;
            Color = color;
        }

        public void Deluge()
        {
            Console.WriteLine("I'm spraying mah firehose");
        }
    }
}
