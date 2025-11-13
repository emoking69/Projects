using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            for (int j = 0; j < 6; j++)
                {
                    System.Console.Write(" ");
                }
                
                System.Console.Write(c);
                
                System.Console.Write(" ");
                System.Console.WriteLine(" ");
            
                for (int j = 0; j < 4; j++)
                {
                    System.Console.Write(" ");
                }
                for (int k = 0; k < 5; k++)
                {
                    System.Console.Write(c);
                }
                System.Console.Write(" ");
                System.Console.WriteLine(" ");
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    System.Console.Write(" ");
                }
                for (int k = 0; k < 3; k++)
                {
                    System.Console.Write(c);
                }
                System.Console.Write(" ");
                System.Console.WriteLine(" ");
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    System.Console.Write(" ");
                }
                for (int k = 0; k < 7; k++)
                {
                    System.Console.Write(c);
                }
                System.Console.Write(" ");
                System.Console.WriteLine(" ");
            }
            Console.ResetColor();
        }
    }
}
