using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_2_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums= 10;
            int[] mass = new int[nums];
            int[] result = new int[nums];
            int numsUnic = 0;
            Random rnd = new Random();
            for (int i = 0; i < nums; i++)
            {
                mass[i] = rnd.Next(nums + nums);
            }

            Console.WriteLine("Рандомный массив: ");
            for (int i = 0; i < nums; i++)
            {
                Console.Write(mass[i] + " ");
            }

            for (int i = 0; i < nums; i++)
            {
                if (!result.Contains(mass[i]))
                    result[numsUnic++] = mass[i];
            }

            Array.Resize(ref result, numsUnic);
            Console.WriteLine("\nМассив без повторений: ");
            for (int i = 0; i < numsUnic; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.ReadKey();
        }
    }
}