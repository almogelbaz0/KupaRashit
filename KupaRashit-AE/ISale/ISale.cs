using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupaRashit_AE.ISale
{
    interface ISale 
    {
        void GetDiscount(Cart cart,Product product);
        string GetName();
    }
}
