using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This is a 3 letter word Palindrome Checking program.");
            Console.Write("Please Enter your first letter: ");
            string letter1 = Console.ReadLine();
            Console.WriteLine("Please Enter your second letter: ");
            string letter2 = Console.ReadLine();
            Console.WriteLine("Finally please enter your third letter: ");
            string letter3 = Console.ReadLine();

            if (letter1 == letter3)
            {
                if (letter2 == "a" && letter2 == "e" && letter2 == "i" && letter2 == "o" && letter2 == "u")
                    Console.WriteLine("{0}{1}{2} is a palindrome", letter1, letter2, letter3);
                else
                    Console.WriteLine("Bro...I don't think thats english, nor even a word...");
            }
            else
                Console.WriteLine("{0}{1}{2} is not a palindrome.", letter1, letter2, letter3);

            Console.WriteLine("That's task 6 finished, press enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
