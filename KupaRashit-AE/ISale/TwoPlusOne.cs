using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupaRashit_AE.ISale
{
    class TwoPlusOne : ISale
    {

        void ISale.GetDiscount(Cart cart, Product product)
        {
            Stack<Product> mySaleType = new Stack<Product>();
            foreach (KeyValuePair<Product, int> entry in cart.MyCart)
            {
                if (entry.Key.sale.GetName() == "TwoPlusOne")
                {
                    for (int i = 0; i < entry.Value; i++)
                    {
                        mySaleType.Push(entry.Key);
                    }
                }
            }
            Dictionary<int,int> IGotThisSale = new Dictionary<int, int>();
            foreach (KeyValuePair<ProductAfterDiscount, int> entry in cart.MyClubCart)
            {
                if (entry.Key.sale.GetName() == "TwoPlusOne")
                {
                    if (IGotThisSale.ContainsKey(entry.Key.BarCode))
                    {
                        IGotThisSale[entry.Key.BarCode] += entry.Value;
                    }
                    else
                    {
                        IGotThisSale.Add(entry.Key.BarCode, entry.Value);
                    }
                }
            }
            int j = 0;
            List<int> IWantThisSale = new List<int>();
            while (IWantThisSale.Count() < 3 && mySaleType.Count() > 0)
            {
                Product thisProduct = mySaleType.Pop();
                if(IGotThisSale.ContainsKey(thisProduct.BarCode) && IGotThisSale[thisProduct.BarCode] > 0)
                {
                    IGotThisSale[thisProduct.BarCode] -= 1 ;
                }
                else
                {
                    IWantThisSale.Add(thisProduct.BarCode);
                }

            }
            int onlyfirst = 0;
            foreach( int barcode in IWantThisSale)
            {
                foreach (KeyValuePair<Product, int> entry in cart.MyCart)
                {
                    if (barcode == entry.Key.BarCode)
                    {
                        ProductAfterDiscount disountedp = new ProductAfterDiscount(entry.Key, entry.Key.UserPrice * onlyfirst);
                        cart.ProcessItem(disountedp, 1);
                        onlyfirst = 1;
                    }
                }
            }
            



        }

        string ISale.GetName()
        {
            return "TwoPlusOne";
        }
    }
}
