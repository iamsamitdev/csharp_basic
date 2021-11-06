using System;

namespace csharp_basic
{
    public class ex3_variable
    {
        public static void ex3(){

            int a = 5;
            int b = 20;

            Console.WriteLine("a = " + a);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("a = {0} b = {1}", a, b);

            int year = 1990;
            string name = "Thomas";
            string nationality = "American";
            
            Console.WriteLine ("His name is {0}", name);
            Console.WriteLine ("He was born in {0}", year);
            Console.WriteLine ("He is {0}", nationality);

        }
    }
}