using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBankApp.Clasess
{
    class BankApp
    {
        public List<User> users;

        public BankApp()
        {
            users = new List<User>();
        }

        public void LaunchAll()
        {

        }


        public void AddUser(string username, string password)
        {
            Random rand = new Random();
            int account = rand.Next(100000000, 999999999);
            users.Add(new User { Username = username, Password = password, Account = account, Balance = 0 });
        }

        public void DeleteUser(int account)
        {
            User user = users.Find(u => u.Account == account);
            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("User " + account + " deleted.");
            }
            else
            {
                Console.WriteLine("User " + account + " does not exist.");
            }
        }

        public User Login(string username, string password)
        {
            User user = users.Find(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                Console.WriteLine("Login successful.");
                return user;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                return null;
            }
        }

        public void Deposit(User user, float amount)
        {
            user.Balance += amount;
            Console.WriteLine("Deposit of $" + amount + " successful. New balance: $" + user.Balance);
        }

        public void Withdraw(User user, float amount)
        {
            if (user.Balance >= amount)
            {
                user.Balance -= amount;
                Console.WriteLine("Withdrawal of $" + amount + " successful. New balance: $" + user.Balance);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void ShowBalance(User user)
        {
            Console.WriteLine("Current balance for user " + user.Username + ": $" + user.Balance);
        }
        public void ShowListOfUsers()
        {
            Console.WriteLine("List of users:");
            foreach (var user in users)
            {
                Console.WriteLine("username : "+user.Username+ "    password : "+user.Password+ "   account : "+user.Account+ "     balance : "+user.Balance);
            }
        }
    }

}

