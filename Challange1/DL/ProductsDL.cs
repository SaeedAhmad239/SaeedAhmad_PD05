using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.BL;

namespace Challange1.DL
{
    internal class ProductsDL
    {
        public static List<Products> product = new List<Products>();
        public static void AddProduct(Products products)
        {
            product.Add(products);
        }
    }
}
