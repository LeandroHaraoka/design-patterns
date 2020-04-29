using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactoryExample.Smartphones
{
    public class AppleSmartphone : Smartphone
    {
        public AppleSmartphone(string name, int randomAccessMemory, float processor, int year)
            : base(name, randomAccessMemory, processor, year)
        {
        }
    }
}
