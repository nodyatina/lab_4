using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ{
    public class Shirt : Clothing
    {
        public double SleeveLength { get; set; }
        public int Size { get; set; }

        public Shirt(double sleeveLength, decimal cost, int size) : base(cost)
        {
           if (sleeveLength <= 0)
            {
                throw new ArgumentException("НЕ МОЖЕТ БЫТЬ МЕНЬШЕ 0");
            }

            SleeveLength = sleeveLength;
            
            if (cost <= 0)
            {
                throw new ArgumentException("ДОЛЖНО БЫТЬ БОЛЬШЕ 0");
            }

            Cost = cost;
            
            if (size <= 0)
            {
                throw new ArgumentException("ДОЛЖЕН БЫТЬ БОЛЬШЕ 0");
            }

            Size = size;
    }
