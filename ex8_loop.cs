using System;

namespace csharp_basic
{
    public class ex8_loop
    {
        public static void ex8(){

            // While Loop
            // int n = 1;
            // while (n <= 10)
            // {
            //     Console.WriteLine("Loop " + n);
            //     n++;
            // }
            // Console.WriteLine("Loop ended");

            // Do-While Loop
            // int n;
            
            // Console.WriteLine("Enter 0 to exit the loop");
            // do
            // {
            //     Console.Write("Your number: ");
            //     int.TryParse(Console.ReadLine(), out n);
            //     Console.WriteLine("Number you entered is " + n);
            // } while (n != 0);
            // Console.WriteLine("Loop ended");

            // For loop
            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // Foreach
            // int[] numbers = { 2, 4, -1, 5, 0, 8, 9 };
            // foreach (int i in numbers)
            // {
            //     Console.WriteLine(i);
            // }

            // Loop with Break
            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine(i);
            //     if (i == 5) break;
            // }

            // Loop Continue
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
            } 

        }
    }
}