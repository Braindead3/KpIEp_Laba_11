using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpIEp_Laba_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraySort= new int[30];
            int[] array= new int[30];

            Console.WriteLine("1.Руками чи 2.рандомно");

            int switch_on= Convert.ToInt32(Console.ReadLine());
            if (switch_on==1)
            {
                InputArray(array);
            }
            else
            {
                RandArray(array);
            }

            Console.WriteLine(string.Join(" ", array));

            Array.Sort(array,new SortByOstatok());

            Console.WriteLine(string.Join(" ",array));

            Console.ReadKey();
        }

        private static void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void RandArray(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10,11);
            }
        }

    }
}
