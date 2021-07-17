using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World!!!");   

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + name);
            Console.ReadKey();

        }
    }
}
