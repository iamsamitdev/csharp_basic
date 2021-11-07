using System;

namespace csharp_basic
{
    public class ex9_arrays
    {
        public static void ex9(){

            // int[] array1 = new int[5];
            // int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            // Console.WriteLine(string.Join(" ", array1));
            // Console.WriteLine(string.Join(" ", array2));
            // Console.WriteLine(array1[0]);
            // Console.WriteLine(array2[2]);
            // Console.WriteLine(array2[6]); // Unhandled exception. System.IndexOutOfRangeException

            // updating array values
            // int[] array1 = new int[5];
            // array1[0] = 2;
            // array1[1] = 43;
            // array1[2] = 54;
            // Console.WriteLine(string.Join(" ", array1));
            
            // reading array value
            // float[] array2 = new float[] {1.2f, 3.4f, 5.0f, 8.8f, 10.5f};
            // Console.WriteLine(array2[0]); // 1.2
            // Console.WriteLine(array2[4]); // 10.5

            // For loop array
            int[] array1 = new int[10];
            for (int i = 0; i < 10; i++){
                array1[i] = (i + 1) * 5;
            }
            
            for (int i = 0; i < 10; i++){
                Console.Write(array1[i] + ", ");
            }

        }
    }
}