using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    internal class SuperList : List<double>
    {
        public (double min, double max) GetMinMax1()
        {
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double num in this)
            {
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }

            return (min, max);
        }
        
        private struct MinMaxValues
        {
            public double Min { get; set; }
            public double Max { get; set; }
        }
        
        
    }
}