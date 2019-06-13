using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a class
            var code = ClassCreationExample.CreateClass();

            // Wait to exit.
            Console.Read();
        }

    }
}

