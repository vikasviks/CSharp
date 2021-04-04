using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqZip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> li = new List<Products> {
                new Products(1, 100, "Title1", "Owner1"),
                new Products(2, 200, "Title2", "Owner2")
            };
            li.Add(new Products(3, 300, "Title3", "Owner3"));
            li.Add(new Products(4, 400, "Title4", "Owner4"));
            li.Add(new Products(5, 500, "Title5", "Owner5"));
            
            List<Distributer> dist = new List<Distributer>();
            dist.Add(new Distributer(1, "vikas"));
            dist.Add(new Distributer(2, "vik"));
            dist.Add(new Distributer(3, "nishu"));
            dist.Add(new Distributer(4, "nish"));
            dist.Add(new Distributer(5, "ABC"));
           

            var x = dist.Zip(dist, (l, dist) => new { l.Id, dist.Name });
            x.ToList().ForEach(t => Console.WriteLine($"Product ID = {t.Id}\t Distributer Name = {t.Name}"));

        }
    }
}
