using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.BL;
using Challange1.DL;

namespace Challange1.UI
{
    internal class ProductsUI
    {
        public static void ViewProducts()
        {
            Products View = new Products();
            Console.WriteLine("Name\t Category\t Price\tAvailable Stock");
            foreach (var item in ProductsDL.product)
                Console.WriteLine("" + View.ProductName + "\t" + View.ProductCategory + "\t" + View.ProductPrice + "\t" + View.AvailableStock);
        }
        public static void ProductsToOrder()
        {
            Products View = new Products();
            foreach (var item in ProductsDL.product)
            {
                if (View.Quantity < View.MinimumStockThreshold)
                    Console.WriteLine(View.ProductName);
            }

        }
    }
}
