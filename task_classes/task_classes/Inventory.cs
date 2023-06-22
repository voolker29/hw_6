﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_classes
{
    internal class Inventory
    {
       List<Product> productsList =new List<Product>();

        public Inventory (params Product[] product)
        {
            productsList.AddRange(product);
        }
        public Inventory(Product product)
        {
            productsList.Add(product);
        
        }
        public Inventory()
        {

        }
        public void AddProduct(Product product)
        {
            productsList.Add(product);        
        }


        public void ShowProductList()
        {

            foreach (var product in productsList)
            {
                Console.WriteLine(product.Id);
            }

        }

        public List<Product> SearchProduct(string stringName)
        { 
          
           var resultSearch = productsList.Where(x=> x.Id == stringName);
           return resultSearch.ToList(); 
        
        
        }
        public List<Product> SearchProduct(Product product)
        {

            var resultSearch = productsList.Where(x => x == product);
            return resultSearch.ToList();

        }

        public int GetProductSumm (Product product )
        {


            var summ = productsList.Where(x => x == product)
                                   .Sum(x => x.Price*x.Count);
            return summ;
        }

        public int GetProductSumm(string product)
        {


            var summ = productsList.Where(x => x.Id == product)
                                   .Sum(x => x.Price*x.Count);
            return summ;
        }

        public int GetAllProductSumm()
        {

            return productsList.Sum(x => x.Count*x.Price);        
        
        }



    }
}
