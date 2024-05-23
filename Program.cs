using System;
using System.Collections.Generic;
using System.Linq; 

namespace LinQ{ 
    class Program
{
    static void Main() 
    {
        
        var clothes = new List<object> 
        {
            new Pants("Denim", 1200, 32), 
            new Pants("Cotton", 900, 30),
            new Shirt(33.5, 850, 40),
            new Shirt(34, 870, 39),
            new Pants("Wool", 1600, 34)
        };

        
        var query = clothes 
        .OfType<dynamic>() 
        .GroupBy(c => c.GetType().Name)
        .Select(g => new
    {
        Type = g.Key,
        TotalCost = g.Sum(c => (decimal)c.Cost)
    });

       
        foreach (var group in query)
        {
            Console.WriteLine($"Тип: {group.Type}, Суммарная стоимость: {group.TotalCost}");
        }
            Console.ReadKey();
    }
}
}