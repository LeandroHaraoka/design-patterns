using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactoryExample.Smartphones.Factories
{
    public class AppleSmartphoneFactory : ISmartphoneFactory
    {
        public Smartphone CreateLowCost() => new AppleSmartphone("IPhone 5C", 1, 1.3f, 2013);

        public Smartphone CreateHyped() => new AppleSmartphone("IPhone XS", 4, 10f, 2018); 

        public Smartphone CreateLuxurious() => new AppleSmartphone("IPhone 11 PRO MAX", 4, 13f, 2019);
    }
}
