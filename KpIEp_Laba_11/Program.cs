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
            int[] array= new int[30];
            InputArray(array);
        }

        private static void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
