using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactoryExample.Smartphones.Factories
{
    public class SamsungSmartphoneFactory : ISmartphoneFactory
    {
        public Smartphone CreateLowCost() => new AppleSmartphone("Samsung J7", 2, 1.6f, 2018);

        public Smartphone CreateHyped() => new SamsungSmartphone("Samsung S10+", 8, 14f, 2019);

        public Smartphone CreateLuxurious() => new AppleSmartphone("Samsung S20", 8, 17f, 2020);
    }
}
