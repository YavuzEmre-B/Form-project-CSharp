using Classes2;
using System;

class program
{
    static void Main()
    {
        Product product1 = new Product() {ProductName = "Laptop", UnitPrice = 50000, UnitInStock = 4  };

        ProductManager productManager = new ProductManager();
        productManager.Add(product1);
    }
}
