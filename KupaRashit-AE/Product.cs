using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupaRashit_AE
{
    class Product
    {
        public float UserPrice { get; set; }
        public string Name { get; set; }
        public float StorePrice { get; set; }
        public int BarCode { get; set; }

        public ISale.ISale sale;

        public Department.Name department;

        public Product(float userprice, float storeprice , int barCode, Department.Name departmentName , string name , ISale.ISale isale)
        {
            UserPrice = userprice ;
            StorePrice = storeprice ;
            BarCode = barCode ;
            department = departmentName ;
            Name = name ;
            sale = isale ;
        }

    }
}
