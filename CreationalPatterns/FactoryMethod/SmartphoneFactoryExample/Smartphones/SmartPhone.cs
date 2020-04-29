using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactoryExample.Smartphones
{
    public abstract class Smartphone
    {
        public string Name { get; set; }
        public int RandomAccessMemory { get; set; }
        public float Processor { get; set; }
        public int Year { get; set; }

        public Smartphone(string name, int randomAccessMemory, float processor, int year)
        {
            Name = name;
            RandomAccessMemory = randomAccessMemory;
            Processor = processor;
            Year = year;
        }
    }
}
