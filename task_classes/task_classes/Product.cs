using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_classes
{
    internal class Product
    {
        public string Id { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        public Product(string id, int count, int price)
        {
           Id    = id;
           Count = count;
           Price = price;

        }
        public Product() 
        {
        }

    }


}
