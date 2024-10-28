// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.WriteLine();
            */


            Console.WriteLine("what is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.WriteLine("Type your last name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName+ " " + myLastName);
            Console.ReadLine();
        }
    }
}
