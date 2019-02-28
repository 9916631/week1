using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;       
            Console.WriteLine("What is your first name?");
            string fname = Console.ReadLine();
            Console.WriteLine("what is your last name?");
            string lname = Console.ReadLine();

            

            
            Console.WriteLine("what is your address?");
            string addy = Console.ReadLine();
            Console.WriteLine("What is your email address?");
            string eaddy = Console.ReadLine();
            Console.WriteLine("what is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your 4 digit pin number?");
            string pin = Console.ReadLine();

            Console.WriteLine("name: " + fname + " " + lname  + "\nAddress: " + addy);
            Console.WriteLine("Email: " + eaddy + "\nage: " + age + "\npin: " + pin);
            Console.ReadLine();

            Console.WriteLine("How many boxes do you have?");
            string box = Console.ReadLine();
            Console.WriteLine("how many lifes do you have?");

        }
    }
}
