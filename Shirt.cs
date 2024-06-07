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
        if (sleeveLength != null)
            {
                SleeveLength = sleeveLength;
            }
            else
            {
                throw new ArgumentNullException("null");
            }
            
            if (cost != null)
            {
                Cost = cost;
            }
            else
            {
                throw new ArgumentNullException( "null");
            }
            
            if (size != null)
            {
                Size = size;
            }
            else
            {
                throw new ArgumentNullException("null");
            }
            
            Shirt = ArgumentNullException
            SleeveLength = sleeveLength;
            Size = size;
        }
    }
