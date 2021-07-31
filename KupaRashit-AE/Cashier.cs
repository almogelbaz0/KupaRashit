using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupaRashit_AE
{
     static class Cashier
    {
        static public void StartOrderWithClub(ClubUser user, Stock stock)
        {
            Cart cart = new Cart(user._id,user.Name,user.CardId,123456789);
            int i = 0;

            while(i >=0)
            {
                Console.WriteLine("Enter BarCode:");
                int barcode = Int32.Parse(Console.ReadLine());
                Product selectedProduct = stock.FindProduct(barcode);
                Console.WriteLine("Enter Amount:");
                int amount = Int32.Parse(Console.ReadLine());
                if (amount <= stock.GetAmount(barcode))
                {
                    cart.AddItem(selectedProduct,amount);
                }

                Console.WriteLine("1. To stay in program , -1 to exit");
                i = Int32.Parse(Console.ReadLine());
            }
            CalculateCart(cart);
            Console.ReadKey();

        }

        static public float CalculateCart(Cart cart)
        {
            int i = 0;
            foreach (KeyValuePair<Product,int> entry in cart.MyCart)
            {
                i = entry.Value;
                while ( i > 0)
                {
                    entry.Key.sale.GetDiscount(cart, entry.Key);
                    i--;
                }
            }

            float sum = 0;
            foreach (KeyValuePair<ProductAfterDiscount, int> entry in cart.MyClubCart)
            {
                sum += entry.Key.PriceAfterDiscount * entry.Value;
                Console.WriteLine("Product:{0}  ,Price:{1}, Amount:{2}", entry.Key.Name, entry.Key.PriceAfterDiscount, entry.Value);
                Console.WriteLine("Discount Type:{0} ", entry.Key.sale.GetName());

            }

            Console.WriteLine(sum);
            return sum;

        }
    }
}
