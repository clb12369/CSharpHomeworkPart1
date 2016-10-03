using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomeworkPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable that holds "Hello World"
            string helloWorld = "Hello World";
            // variable that holds 1492
            int year = 1492;
            // variable that holds hasDog
            bool hasDog = true;
            // variable that holds today's date (as string)
            string dateToday = "10/03/2016";
            // variable that holds $5.45
            float price = 5.45f;
            // variable that holds single letter (char) X
            char x = 'X';

            Console.WriteLine(helloWorld);
            Console.ReadLine();

            Console.WriteLine("Columbus Sailed the world in {0}. ", year);
            Console.ReadLine();

            Console.WriteLine("It is {0} that I have a dog at home.", hasDog);
            Console.ReadLine();

            Console.WriteLine("Today is {0}.", dateToday);
            Console.ReadLine();

            Console.WriteLine("I spent ${0} on a cheeseburger.", price);
            Console.ReadLine();

            Console.WriteLine("{0} marks the spot.", x);
            Console.ReadLine();

        }
    }
}
