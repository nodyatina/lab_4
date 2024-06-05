using System;
using System.Collections.Generic;
using System.Linq; 

namespace LinQ
{
    class Program
    {
        static void Main()
        {
            var clothes = new List<Clothing>
            {
                new Pants("Denim", 1200, 32),
                new Pants("Cotton", 900, 30),
                new Shirt(33.5, 850, 40),
                new Shirt(34, 870, 39),
                new Pants("Wool", 1600, 34)
            };

            var query = clothes
                .GroupBy(c => c.GetType().Name)
                .Select(g => new
                {
                    Type = g.Key,
                    TotalCost = g.Sum(c => c.Cost)
                });

            foreach (var group in query)
            {
                Console.WriteLine($"Type: {group.Type}, Total Cost: {group.TotalCost}");
            }
            Console.ReadKey();
        }
    }

    public abstract class Clothing
    {
        public decimal Cost { get; set; }

        protected Clothing(decimal cost)
        {
            if (cost < 0)
            {
                throw new ArgumentException("Cost cannot be negative");
            }
            Cost = cost;
        }
    }
