using System;

namespace csharp_basic
{
    public class ex7_condition
    {
        public static void ex7(){

            // string name = "John Wick";
            // if (name == "John Wick") {
            //     Console.WriteLine("Welcome, John Wick!");
            // }

            // Condition If else
            // int score;
            
            // Console.Write("Enter your score: ");
            // int.TryParse(Console.ReadLine(), out score);
            
            // if(score >= 80) {
            //     Console.WriteLine("Your grade is A");
            // }
            // else if(score >= 70) {
            //     Console.WriteLine("Your grade is B");
            // }
            // else if (score >= 60)
            // {
            //     Console.WriteLine("Your grade is C");
            // }
            // else if (score >= 50)
            // {
            //     Console.WriteLine("Your grade is D");
            // }
            // else {
            //     Console.WriteLine("You fall");
            // }

            // int mode;
            // float temperature;
            
            // Console.Write("1: convert F to C\n2: convert C to F\n");
            // Console.Write("Enter 1 or 2: ");
            // int.TryParse(Console.ReadLine(), out mode);
            
            // Console.Write("Enter temperature to be converted: ");
            // float.TryParse(Console.ReadLine(), out temperature);
            
            // if (mode == 1) {
            //     float c = (temperature - 32) * (5.0f / 9.0f);
            //     Console.WriteLine("Converted {0} Fahrenheit degree to {1} Celsius degree", temperature, c);
            // } 
            // else if (mode == 2) {
            //     float f = temperature * 1.8f + 32;
            //     Console.WriteLine("Converted {0} Celsius degree to {1} Fahrenheit degree", temperature, f);
            // } 
            // else {
            //     Console.WriteLine("You've entered wrong mode.");
            // }

            int n = 3;
            switch(n) {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }
    }
}