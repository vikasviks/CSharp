using core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace infrastructure
{
    public class Inventory
    {
        static ArrayList list = new ArrayList();
        public void AddProduct(string title, string color, decimal price) {
            list.Add(new Product
            {
                Title = title,
                Color = color,
                Price = price
            });
        }
        static Inventory()
        {
            list.Add(new Product
            {
                Title = "Pen",
                Color = "Blue",
                Price = 10
            });
            list.Add(new Product
            {
                Title = "Pencil",
                Color = "Black",
                Price = 5
            });
            list.Add(new Product
            {
                Title = "Bat",
                Color = "White",
                Price = 450
            });
            list.Add(new Product
            {
                Title = "Ball",
                Color = "Green",
                Price = 50
            });
            list.Add(new Product
            {
                Title = "Stumps",
                Color = "White",
                Price = 250
            });
        }
        public override string ToString()
        {
            string s = "\nTitle\tColor\tPrice";
            foreach (Product l in list) {
                s += "\n" + l.Title + "\t" + l.Color + "\t" + l.Price; 
            }
            return s;
        }
    }
   
}
