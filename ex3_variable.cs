using System;

namespace csharp_basic
{
    public class ex3_variable
    {
        public static void ex3(){

            // int a = 5;
            // int b = 20;

            // Console.WriteLine("a = " + a);
            // Console.WriteLine("a = {0}", a);
            // Console.WriteLine("b = {0}", b);
            // Console.WriteLine("a = {0} b = {1}", a, b);

            // int year = 1990;
            // string name = "Thomas";
            // string nationality = "American";
            
            // Console.WriteLine ("His name is {0}", name);
            // Console.WriteLine ("He was born in {0}", year);
            // Console.WriteLine ("He is {0}", nationality);

            // ตัวแปรเก็บข้อมูลประเภท Boolean

            // bool isDay = false;
            
            // if (isDay)
            // {
            //     Console.WriteLine("Good morning.");
            // }
            // else
            // {
            //     Console.WriteLine("Good night.");
            // }
            
            // bool gameOver = true;
            // Console.WriteLine("Game over = {0}", gameOver);

            // ตัวแปรเก็บข้อมูลประเภท Number

            // int apple = 10;
            // int mango = 5;
            // int totalFruit = apple + mango;
            
            // Console.WriteLine("We have {0} fruits in the basket", totalFruit);
            
            // byte month = 12;
            // byte day = 10;
            // short year = 2016;
            
            // Console.WriteLine("Date {0}/{1}/{2}", month, day, year);
            
            // decimal bigNumber = 9460730472580800;
            // Console.WriteLine(bigNumber.ToString("0.00000E0"));
            
            // int max = Int32.MaxValue;
            // Console.WriteLine(max);
            // max = max + 1;
            // Console.WriteLine(max);


            // ตัวแปรเก็บข้อมูลประเภท Float and Decimal
            float speed = 8.3f;
            float time = 10.258987894445f;
            float distance = speed * time;
            
            Console.WriteLine("Mateo runs at speed {0} m/s in {1} seconds", speed, time);
            Console.WriteLine("Total run distance {0} meters", distance);
            
            Console.WriteLine("------------------");
            
            float lightSpeed = 5.8786E12f; // 5.8786 x 10^12 
            Console.WriteLine("Light can travel {0} miles in 1 year", lightSpeed);
            
            Console.WriteLine("------------------");
            
            double day = 365.2578954658789567;
            double neutronMass = 1.674927471E-27;
            double pi = 22 / 7.0f;
            Console.WriteLine("Earth take about {0} day to orbit the sun", day);
            Console.WriteLine("PI value = {0}", pi);
            Console.WriteLine("Neutron Mass = {0} kg", neutronMass);
            
            Console.WriteLine("------------------");
            
            // Difference between decimal, float and double
            // Float - 7 digits (32 bit)
            // Double-15-16 digits (64 bit)
            // Decimal -28-29 significant digits (128 bit)
            
            float flt = 1F/3;
            double dbl = 1D/3;
            decimal dcm = 1M/3;
            Console.WriteLine("float: {0} \ndouble: {1} \ndecimal: {2}", flt, dbl, dcm);

        }
    }
}