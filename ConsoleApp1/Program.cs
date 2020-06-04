using OOP;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Lion : Cat
    {
        public Lion(float tailLength, float clawsLength) : base(tailLength, clawsLength) { }

       
    }
}
