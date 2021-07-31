using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupaRashit_AE
{
    class Stock
    {
        public Dictionary<Product, int> MyStock = new Dictionary<Product, int>();

        public Stock(Product product, int amount)
        {
           
            MyStock.Add(product, amount);

        }
        public void AddProduct(Product product, int amount)
        {
            MyStock.Add(product, amount);
        }

        public int GetAmount(int barcode)
        {

            foreach (KeyValuePair<Product, int> entry in MyStock)
            {
                // do something with entry.Value or entry.Key
                if (entry.Key.BarCode  == barcode )
                {
                    return entry.Value;
                }
            }
            return 0;

        }

        public Product FindProduct(int barcode)
        {
            foreach (KeyValuePair<Product, int> entry in MyStock)
            {
                // do something with entry.Value or entry.Key
                if (entry.Key.BarCode == barcode)
                {
                    return entry.Key;
                }
            }
            return null;
        }




    }
}
