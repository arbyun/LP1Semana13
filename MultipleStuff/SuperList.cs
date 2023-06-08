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
        
        public (double min, double max) GetMinMax2()
        {
            MinMaxValues minMax = new MinMaxValues();

            foreach (double num in this)
            {
                if (num < minMax.Min)
                    minMax.Min = num;
                if (num > minMax.Max)
                    minMax.Max = num;
            }

            return (minMax.Min, minMax.Max);
        }
        
        public Tuple<double, double> GetMinMax3()
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

            return Tuple.Create(min, max);
        }


    }
}