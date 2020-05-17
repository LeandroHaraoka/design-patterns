using System;
using System.Collections.Generic;

namespace AssetManagementExample
{
    public static class Curves
    {
        public static readonly Dictionary<DateTime, decimal> DICurve = CreateDICurve();

        private static Dictionary<DateTime, decimal> CreateDICurve()
        {
            var currentDate = new DateTime(2020, 01, 01);
            var finalDateTime = new DateTime(2020, 01, 30);

            var curve = new Dictionary<DateTime, decimal>();
            var value = 0.03m;

            while (currentDate <= finalDateTime)
            {
                curve.Add(currentDate, value);
                value += 0.001m;
                currentDate = currentDate.AddDays(1);
            }

            return curve;
        }
    }
}
