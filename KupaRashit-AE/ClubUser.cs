using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KupaRashit_AE
{
    class ClubUser : User
    {
        public int CardId { get; set; }
        public int Points { get; set; }
        private int _creditCard { get; set;}

        public ClubUser(int id , string name , int cardId ) : base( id , name)
        {
            CardId = cardId;
        }


    }
}
