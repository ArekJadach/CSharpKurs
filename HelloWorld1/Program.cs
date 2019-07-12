using System;

namespace HelloWorld1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];
            Console.WriteLine("Witaj " + name);

            //foreach (var name in args)
            //{
            //    Console.WriteLine("Witaj " + name);
            //}
        }
    }
}
