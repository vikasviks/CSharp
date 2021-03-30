using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Generic<int>> Ilist = new List<Generic<int>>();
            Ilist.Add(new Generic<int> { member = 1 });
            Ilist.Add(new Generic<int> { member = 12 });
            Ilist.Add(new Generic<int> { member = 13 });
            

            var x = Ilist.Where((a)=> a.member>12 ).Select((a)=> a);
            x.ToList().ForEach((i) => i.Print());
           
            var y = from a in Ilist where a.member > 12 select a;
            y.ToList().ForEach((i) => i.Print());
            

            List<Generic<Product>> pro = new List<Generic<Product>>();
            pro.Add(new Generic<Product> { member = new Product { ID = 1, Title = "Pen", Price = 100 } });
            pro.Add(new Generic<Product> { member = new Product { ID = 2, Title = "Pencil", Price = 10 } });
            pro.Add(new Generic<Product> { member = new Product { ID = 3, Title = "Bat", Price = 1500 } });

            var p = pro.Where((g) => g.member.Price < 500).Select((g) => g);
            p.ToList().ForEach((i) => i.Print());
            
            var q = from g in pro where g.member.Price < 500 select g;
            q.ToList().ForEach((i) => i.Print());
            
        }
    }
}
