using System;

namespace csharp_basic
{
    public class ex4_input
    {
        public static void ex4(){
            Console.Write("Enter your name, please: ");
            string sName = Console.ReadLine();

            Console.Write("Enter your email, please: ");
            string sEmail = Console.ReadLine();

            Console.WriteLine("Hello," + sName);
            Console.WriteLine("Your email is ," + sEmail);
        }
    }
}