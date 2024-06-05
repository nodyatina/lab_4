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
            SleeveLength = sleeveLength;
            Size = size;
        }
    }
