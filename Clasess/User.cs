using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBankApp.Clasess
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public float Balance { get; set; }
        public int Account { get; set; }

        /*public int account;
        public int Account { 
            get {
                return account;
                }
            set {
                Random rand = new Random();
                account = rand.Next(10000000, 99999999);
                }
        }*/
    }
}
