using System;

namespace csharp_basic
{
    public class ex10_method
    {
        public static void ex10(){
            
            // String name = "John";
            // int sex = 0;
            // String sport= "hockey";
            
            // displayBio(name, sex, sport);
            // displayBio("Janifer", 1, "swimming");
            // displayBio("Carl", 0, "football");

            int a = 10;
            int b = 25;
            Console.WriteLine(getText(a) + getSum(a));
            Console.WriteLine(getText(b) + getSum(b));
            Console.WriteLine(getEndText());

        }

        // สร้างฟังก์ชัน displayBio
        static void displayBio(String n, int s, String sp) {
            if (s == 0) {
                Console.WriteLine(n + " has " + sp + " as his favorite sport.");
            } else {
                Console.WriteLine(n + " has " + sp + " as her favorite sport.");
            }
        }

        static string getText(int n) {
            return "Sum bewteen 1-" + n + " is ";
        }
        
        static int getSum(int n) {
            int sum = 0;
            for (int i = 1; i <= n; i++) {
                sum += i;
            }
            return sum;
        }
        
        static string getEndText() {
            return "Program ended.";
        }
        
    }
}