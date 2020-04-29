using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneFactoryExample.Smartphones.Factories
{
    public interface ISmartphoneFactory
    {
        Smartphone CreateLowCost();
        Smartphone CreateHyped();
        Smartphone CreateLuxurious();
    }
}
