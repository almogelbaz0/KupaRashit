using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupaRashit_AE.ISale
{
    class _50Precent : ISale
    {
        public Dictionary<int,Product> AppliedProducts; // int is BarCode

        public string GetName()
        {
            return "50 %";
        }
        public void GetDiscount(Cart cart,Product product)
        {
            foreach (KeyValuePair<Product, int> entry in cart.MyCart)
            {
                if (product.BarCode == entry.Key.BarCode)
                {
                    ProductAfterDiscount disountedp = new ProductAfterDiscount(entry.Key, entry.Key.UserPrice * (float)0.5);
                    cart.ProcessItem(disountedp, 1);
                    return;
                }
            }
        }
    }
}
