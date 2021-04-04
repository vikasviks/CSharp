using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassAndAction
{
    public class Products
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Owner { get; set; }
        public Products(int id, int pr, string ti, string ow)
        {
            ID = id;
            Price = pr;
            Title = ti;
            Owner = ow;
        }
    }
}
