using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: ");
            string Username = Console.ReadLine();
            Console.Write("Enter your Age: ");
            string Age = Console.ReadLine();
            Console.Write("Enter your Account Number: ");
            string Accountnumber = Console.ReadLine();

            

            Console.WriteLine("\n------------------Account Details----------------------\n");

            
            Userdetails(Username, Age, Accountnumber);
            Accountbalance();
            Console.WriteLine("\nPress any key to exit...................");
            Console.ReadKey();
            
        }

        static void Userdetails(string Username, string Age, string Accountnumber)
        {          
            List<string> Accountdetails = new List<string>();

            Accountdetails.Add(Username);
            Accountdetails.Add(Age);
            Accountdetails.Add(Accountnumber);

            Console.WriteLine("Name: {0}", Accountdetails[0]);
            Console.WriteLine("Age: {0}", Accountdetails[1]);
            Console.WriteLine("Account Number: {0}", Accountdetails[2]);            

        }

        static void Accountbalance()
        {
            List<double> useraccountbalance = new List<double>();

            useraccountbalance.Add(50000);

            Console.WriteLine("Account Balance: {0}", useraccountbalance[0]);

            Console.WriteLine("\n    1. Withdraw Cash    2. Deposit Cash\n");
            Console.Write("Select your required action: ");
            int Action = Convert.ToInt16( Console.ReadLine());

            if (Action == 1)
            {
                Console.Write("\nEnter the withdraw ammount: ");
                double withdraw = Convert.ToDouble(Console.ReadLine());

                double Newbalance = useraccountbalance[0] - withdraw;

                Console.WriteLine("\n----------- Case Withdraw Completed -----------------\n ");

                useraccountbalance[0] = Newbalance;
                Console.WriteLine("Your Account Balance: {0}", useraccountbalance[0]);
            }

            if (Action == 2)
            {
                Console.WriteLine("\n------- Cash deposit temporarily Unavailable-----------");
            }

        }

       
    }
    
}
