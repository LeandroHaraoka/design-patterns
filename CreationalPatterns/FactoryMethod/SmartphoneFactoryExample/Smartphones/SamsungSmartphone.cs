using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactoryExample.Smartphones
{
    public class SamsungSmartphone : Smartphone
    {
        public SamsungSmartphone(string name, int randomAccessMemory, float processor, int year)
            : base(name, randomAccessMemory, processor, year)
        {
        }
    }
}
