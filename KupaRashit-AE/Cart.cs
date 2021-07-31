using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupaRashit_AE
{
    class Cart : ClubUser 
    {
        public int CartID;
        public Dictionary<Product, int> MyCart = new Dictionary<Product, int>();
        public Dictionary<ProductAfterDiscount, int> MyClubCart = new Dictionary<ProductAfterDiscount, int>();

        public Cart(int id, string name ,int cardId, int cartId) : base (id , name , cardId)
        {
            CartID = cartId;
        }

        public void AddItem(Product product , int amount)
        {
            foreach (KeyValuePair<Product,int> entry in MyCart)
            {
                if (  entry.Key.BarCode == product.BarCode)
                {
                    MyCart[entry.Key] = entry.Value + amount;
                    
                    return;
                }
            }
            MyCart.Add(product, amount);
        }

        public void ProcessItem(ProductAfterDiscount product, int amount)
        {
            foreach (KeyValuePair<ProductAfterDiscount, int> entry in MyClubCart)
            {
                if (entry.Key.BarCode == product.BarCode && entry.Key.PriceAfterDiscount == product.PriceAfterDiscount)
                {
                    MyClubCart[entry.Key] = entry.Value + amount;

                    return;
                }
            }
            MyClubCart.Add(product, amount);
        }




        //public Stack<Tuple<Product, int>> HaveBeenProcesed;
    }
}
