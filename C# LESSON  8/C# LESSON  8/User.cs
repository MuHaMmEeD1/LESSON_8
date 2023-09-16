using C__LESSON_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON__8
{
    public class User
    {
        public User(string name, string surname, Card creditCard)
        {
            Name = name;
            Surname = surname;
            CreditCard = creditCard;
        }

        public User()
        {
           
        }

        public string Name { get; set; }    
        public string Surname { get; set; }    
        public Card CreditCard { get; set; }





    }
}
