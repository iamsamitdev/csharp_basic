using System;

namespace csharp_basic
{
    public class ex5_constant
    {
        public static void ex5(){

            // const float PI = 3.14f;
            // // PI = 1.0f; // Invalid
            // float r = 4;
            
            // float area = PI * r * r;
            // float circumference = 2 * PI * r;
            // float volume = (4 / 3.0f) * PI * r * r * r;
            // float surface = 4 * PI * r * r;
            
            // Console.WriteLine("Circle radius = {0}", r);
            // Console.WriteLine("Circle area = {0}", area);
            // Console.WriteLine("Circle circumference = {0}", circumference);
            // Console.WriteLine("Circle volume = {0}", volume);
            // Console.WriteLine("Circle surface = {0}", surface);

            const int SIZE = 5;
            
            string[] names = new string[SIZE];
            int[] scores = new int[SIZE];
            
            Console.WriteLine("Enter name and score of {0} players", SIZE);
            
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write("Player {0} name: ", i + 1);
                names[i] = Console.ReadLine();
                Console.Write("Player {0} score: ", i + 1);
                scores[i] = Int32.Parse(Console.ReadLine());
            }
            
            int maxIndex= 0;
            
            for (int i = 0; i < SIZE; i++)
            {
                if (scores[i] > scores[maxIndex])
                {
                    maxIndex = i;
                }
            }
            
            Console.WriteLine("{0} is the winner with score {1}", names[maxIndex], scores[maxIndex]);

        }
    }
}