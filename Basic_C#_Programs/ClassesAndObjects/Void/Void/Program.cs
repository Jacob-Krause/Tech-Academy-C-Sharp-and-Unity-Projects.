﻿using System;

namespace Void
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidOperations operation = new VoidOperations();
            Console.Write("We will be doing some math operations with some numbers.");
            Console.WriteLine("");
            Console.Write("Press enter to start the program.");
            Console.ReadLine();

            operation.VOperations(5, 10);

            Console.Write("Now we will do the same math with some numbers of your choice.");
            Console.WriteLine("");
            Console.WriteLine("Press enter to begin ");
            Console.ReadLine();

            Console.Write("Please enter your first number: ");
            int userVal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            int userVal2 = Convert.ToInt32(Console.ReadLine());
            operation.VOperations(userVal1, userVal2);


            Console.Write("Press enter to end this program.");
            Console.ReadLine();
        }
    }
}
