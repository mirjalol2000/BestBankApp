using BestBankApp.Clasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankApp bankApp = new BankApp();
            key:
            bool check = true;
            while(check ==true) {

                Console.WriteLine("1.Create account\n2.Login\n3.Show users\n4.Delete user");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    Console.Write("Username : ");
                    string username = Console.ReadLine();
                    Console.Write("Password : ");
                    string password = Console.ReadLine();
                    // Add user
                    bankApp.AddUser(username, password);
                    Console.WriteLine("Account is created!!!");
                }
                else if (n == 2)
                {
                    // Login user
                    Console.Write("Enter your username : ");
                    string username = Console.ReadLine();
                    Console.Write("Enter your password : ");
                    string password = Console.ReadLine();
                    User user = bankApp.Login(username, password);
                    if (user != null)
                    {
                        bool check2 = true;
                        while (check2 == true)
                        {

                            Console.WriteLine("1.Deposit money\n2.Withdraw money\n3.Show balance\n4.Exit");
                            int n2 = Convert.ToInt32(Console.ReadLine());

                            // Perform transactions
                            if (n2 == 1)
                            {
                                Console.WriteLine("How much did you want to put Deposit ?");
                                float amount = Convert.ToSingle(Console.ReadLine());
                                bankApp.Deposit(user, amount);
                            }
                            else if (n2 == 2)
                            {
                                Console.WriteLine("How much did you want to withdraw money ?");
                                float amount = Convert.ToSingle(Console.ReadLine());
                                bankApp.Withdraw(user, amount);
                            }
                            else if (n2 == 3)
                            {
                                bankApp.ShowBalance(user);
                            }
                            else if(n2==4)
                            {
                                goto key;
                            }

                        }
                    }
                }

                else if (n == 3)
                {
                   
                    bankApp.ShowListOfUsers();
                }

                else if (n == 4)
                {
                    Console.WriteLine("Enter account number : ");
                    int account = Convert.ToInt32(Console.ReadLine());
                    // Delete user
                    bankApp.DeleteUser(account);
                }


            }
            

            Console.ReadKey();
        }
    }
}
