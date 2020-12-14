using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeconEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[5];
            Random random = new Random();

            for (int i = 0; i < circles.Length; i++)
            {
                circles[i] = new Circle(random.Next(0,11), random.Next(0, 11), random.Next(0, 11));
            }

            for (int i = 0; i < circles.Length; i++)
            {
                Console.WriteLine(circles[i].ToString());
                Console.WriteLine();
            }

            Console.WriteLine("luba\n");
            Array.Sort(circles);

            for (int i = 0; i < circles.Length; i++)
            {
                Console.WriteLine(circles[i].ToString());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
