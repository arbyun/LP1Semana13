using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    internal class SuperList : List<double>
    {
        public void GetMinMax1(out double min, out double max)
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("A lista está vazia.");
            }
        
            min = double.MaxValue;
            max = double.MinValue;

            foreach (double item in this)
            {
                if (item < min)
                {
                    min = item;
                }

                if (item > max)
                {
                    max = item;
                }
            }
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
        
        public (double minValue, double maxValue) GetMinMax4()
        {
            double minValue = double.MaxValue;
            double maxValue = double.MinValue;

            foreach (double num in this)
            {
                if (num < minValue)
                    minValue = num;
                if (num > maxValue)
                    maxValue = num;
            }

            return (minValue, maxValue);
        }
    }
}