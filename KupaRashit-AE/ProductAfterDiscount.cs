using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupaRashit_AE
{
    class ProductAfterDiscount : Product
    {
        public float PriceAfterDiscount { get; set; }

        public ProductAfterDiscount(Product product, float price) : base(product.UserPrice, product.StorePrice, product.BarCode,product.department, product.Name,  product.sale)
        {
            PriceAfterDiscount = price;
        }

    }
}
