using System;
using System.Collections.Generic;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService proxy = new ProxyService("ahmet","1234");
            proxy.getProducts();
            proxy.removeProduct(2);

        }
    }
}
