using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Products : IProductService
    {
        List<string> Urun = new List<string>() { "Ayakkabı", "Saat", "Şort" };
        public List<string> getProducts()
        {
            foreach (var item in Urun)
            {
                Console.WriteLine(item);
            }
            return Urun;
        }


        public List<string> removeProduct(int a)
        {
            Urun.RemoveAt(a);
            foreach (var item in Urun)
            {
                Console.WriteLine(item);
            }
            return Urun;
        }
    }
}
