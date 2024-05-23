using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ{
    public class Shirt
{
    public double SleeveLength { get; set; }
    public decimal Cost { get; set; }
    public int Size { get; set; }

    public Shirt(double sleeveLength, decimal cost, int size)
    {
        SleeveLength = sleeveLength;
        Cost = cost;
        Size = size;
    }
}
}