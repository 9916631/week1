using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staceyapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;


            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Name: " + name +"\nAge: "+ age);
            Console.ReadLine();

            string colour;
            int number;

            Console.WriteLine("what colour is your hair");
            colour = Console.ReadLine();
            Console.WriteLine("how many times do you die your hair");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine(colour + number);
            Console.ReadLine();

            
            Console.WriteLine("How many ps4's do you own??");
            int numOfPS4 = int.Parse(Console.ReadLine());
            

        }

    }
}
