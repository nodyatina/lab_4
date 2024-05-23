using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ{
    public class Pants
{
    public string Material { get; set; } 
    public decimal Cost { get; set; }
    public int Size { get; set; }

    public Pants(string material, decimal cost, int size) 
            

    {
        Material = material ?? throw new ArgumentNullException(nameof(material)); 
        Cost = cost;
        Size = size;
    }
}
}