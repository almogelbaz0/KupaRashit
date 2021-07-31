using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupaRashit_AE
{
    class User
    {
        public int _id { get; set; }
        
        public string Name { get; set;}

        public User(int id, string name)
        {
            _id = id;
            Name = name;
        }


    }
}
