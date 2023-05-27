// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Ex4.1 - thiết kế menu
using System;
namespace Ex4_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do{
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch(choice)
                {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    DrawTriangle();
                    break;
                case 2:
                    DrawSquare();
                    break;
                case 3:
                    DrawRectangle();
                    break;
                    }
            }while(choice != 0);
        }
        static void DrawTriangle()
        {
            Console.WriteLine("Draw the triangle");
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void DrawSquare()
        {
            Console.WriteLine("Draw the square");
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void DrawRectangle()
        {
            Console.WriteLine("Draw the rectangle");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
