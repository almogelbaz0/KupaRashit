using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupaRashit_AE
{
    class Program
    {
        static void Main(string[] args)
        {
            ISale.ISale fiftyp = new ISale._50Precent();
            ISale.ISale TwoPlusOne = new ISale.TwoPlusOne();


            Product bamba = new Product(10, 5, 143, Department.Name.Snacks, "BambaShush",fiftyp);
            Product bamba1 = new Product(11, 5, 1432, Department.Name.Snacks, "BambaShush1", fiftyp);
            Product bamba2 = new Product(13, 5, 1433, Department.Name.Snacks, "BambaShush2", fiftyp);
            Product bamba3 = new Product(7, 3, 1473, Department.Name.Snacks, "BambaShush3", TwoPlusOne);
            Product bamba4 = new Product(3, 1, 14453, Department.Name.Snacks, "BambaShush4", TwoPlusOne);
            Product bamba5 = new Product(11, 5, 1413, Department.Name.Snacks, "BambaShush5", fiftyp);
            Product bamba6 = new Product(14, 5, 1493, Department.Name.Snacks, "BambaShush6", fiftyp);

            Stock stock = new Stock(bamba, 200);
            stock.AddProduct(bamba2, 150);
            stock.AddProduct(bamba1, 950);
            stock.AddProduct(bamba3, 350);
            stock.AddProduct(bamba4, 550);
            stock.AddProduct(bamba5, 450);
            stock.AddProduct(bamba6, 250);

            ClubUser user = new ClubUser(123456, "almog", 455178870);

            
            Cashier.StartOrderWithClub(user, stock);

        }
    }
}
