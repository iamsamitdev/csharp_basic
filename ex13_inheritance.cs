using System;

namespace csharp_basic
{
    
    // Interface
    // Enum
    // Object
    // ArrayList

    public class ex13_inheritance
    {
        public static void ex13()
        {
    
            Rectangle rec1 = new Rectangle(3, 4);
            Console.WriteLine("Rectangle 1");
            Console.WriteLine("size [{0}, {1}]", rec1.x, rec1.y);
            Console.WriteLine("Area = {0}", rec1.GetArea());
            Console.WriteLine();
    
            Cuboid cub1 = new Cuboid(5, 3, 4);
            Console.WriteLine("Cuboid 1");
            Console.WriteLine("size [{0}, {1}, {2}]",
            cub1.x, cub1.y, cub1.z);
            Console.WriteLine("Volume = {0}", cub1.GetVolume());
            Console.WriteLine();
    
            Cuboid cub2 = new Cuboid(10, 10, 10);
            Console.WriteLine("Cuboid 2");
            Console.WriteLine("size [{0}, {1}, {2}]",
            cub2.x, cub2.y, cub2.z);
            Console.WriteLine("Volume = {0}", cub2.GetVolume());
    
        }
    }

    // สร้าง Class Rectangle เป็น class แม่ (base class)
    class Rectangle
    {
        public int x;
        public int y;
    
        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    
        public double GetArea()
        {
            return x * y;
        }
    }

    // สร้าง Class Cuboid เป็น class ลูก (child class)
    class Cuboid : Rectangle
    {
        public int z;
    
        public Cuboid(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
    
        public double GetVolume()
        {
            return GetArea() * z;
        }
    }



}