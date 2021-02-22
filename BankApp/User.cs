using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class User
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string card_namber { get; set; }
        public int balanse { get; set; }
        public string pin { get; set; }

        //public User(string login, string password, string card_number)
        //{
        //    this.card_namber = card_namber;
        //    this.login = login;
        //    this.password = password;
        //}
    }

}
