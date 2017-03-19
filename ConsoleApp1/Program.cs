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
            //HelloWorld();
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.Write("What is your city: ");
            string city = Console.ReadLine();

            string reversedName = ReverseString(name);
            string reversedCity = ReverseString(city);

            ReverseString(name);
            ReverseString(city);
            Console.ReadLine();
        }

        //private static void HelloWorld()
        //{
        //    Console.WriteLine("Hello World");
        //}

        private static string ReverseString( string message )
        {
            
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
           
        }
    }
}
