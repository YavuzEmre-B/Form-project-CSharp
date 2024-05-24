using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    //methods
    //reuseability
    internal class ProductManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Urun Eklendi: " + product.ProductName);
        }
    }
}
