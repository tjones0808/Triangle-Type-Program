using System;

namespace Triangle_Type_Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunProgram();
            
        }

        static void RunProgram()
        {
            int a, b, c;
            Console.WriteLine("Please input 3 integers, and I will determine the type of triangle.");
            Console.Write("Side 1: ");
            if (int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Side 2: ");
                if (int.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("Side 3: ");
                    if (int.TryParse(Console.ReadLine(), out c))
                    {
                        // run function with inputs and return side type
                        var triangleType = DetermineTriangleType(a, b, c);

                        Console.WriteLine("Triangle Type: " + triangleType);
                    }
                    else
                    {
                        Console.WriteLine("Please Input Integers");
                    }
                }
                else
                {
                    Console.WriteLine("Please Input Integers");
                }
            }
            else
            {
                Console.WriteLine("Please Input Integers");
            }
        }

        public static string DetermineTriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if (a == b && b != c || b == c && c != a || a == c && a != b)
            {
                return "Isosceles";
            }
            else
                return "Scalene";
        }

    }
}
