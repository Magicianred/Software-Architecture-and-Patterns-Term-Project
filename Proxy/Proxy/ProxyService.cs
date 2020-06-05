using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ProxyService:IProductService
    {
        public bool authProcess { get; private set; }
        private Products _products = new Products();
        public ProxyService(string username,string pass)
        {
            if (username == "ahmet" && pass == "1234")
            {
                Console.WriteLine("Başarıyla Giriş Yapıldı.\n");
                authProcess = true;
            }
            else
            {
                Console.WriteLine("Hatalı şifre girişi\n");
                authProcess = false;
            }
        }
       
        public List<string> getProducts()
        {
            //Authorization();
            if (authProcess)
            {
                Console.WriteLine("Ürünlerin Listesi\n");
                return _products.getProducts();
            }
            else
            {
                Console.WriteLine("Önce giriş yapınız.\n");
                return null;
            }
        }
        public List<string> removeProduct(int ad)
        {
            //Authorization();
            if (authProcess)
            {
                Console.WriteLine("\nAlmak istediğiniz ürünü seçin\n");
                Console.WriteLine("Ürün başarıyla alındı. Kalan Ürünler \n");
                return _products.removeProduct(ad);
            }
            else
            {
                Console.WriteLine("Önce giriş yapınız.\n");
                return null;
            }
        }
    }
}
