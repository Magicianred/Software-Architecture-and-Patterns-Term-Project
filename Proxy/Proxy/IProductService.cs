using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    interface IProductService
    {
        List<string> getProducts();
        List<string> removeProduct(int ad);
    }
}
