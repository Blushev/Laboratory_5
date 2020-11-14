using System;
using System.Globalization;

namespace Laboratory_5
{
    using System;

    class Program
    { 
        static void Edge(int factorial, char left_angle, char center, char right_angle)
        {
            int factorial_number = factorial;
            Console.Write(left_angle);
            Console.Write(center);
            while (factorial_number != 0)
            {
                factorial_number /= 10;
                Console.Write(center);
            }
            Console.Write(center);
            Console.WriteLine(right_angle);
        }


        static void Edge_Center(int factorial, char left, char nothing, char right)
        {
            Console.Write(left);
            Console.Write(nothing);
            Console.Write(factorial);
            Console.Write(nothing);
            Console.WriteLine(right);
        }


        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for(int i = 1; i <= num; i++)
                factorial *= i;

            Edge(factorial, '╔', '═', '╗');
            Edge_Center(factorial, '║', ' ', '║');
            Edge(factorial, '╚', '═', '╝');
            Console.ReadKey();
        }
    }
}