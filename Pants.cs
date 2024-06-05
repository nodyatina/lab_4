using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ{
    public class Pants : Clothing
    {
        public string Material { get; set; }
        public int Size { get; set; }

        public Pants(string material, decimal cost, int size) : base(cost)
        {
            Material = material ?? throw new ArgumentNullException(nameof(material), "Material cannot be null");
            Size = size;
        }
    }
