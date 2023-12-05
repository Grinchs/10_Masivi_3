using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Masivi_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];

            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 21); 
            }

            
            
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"mas[{i + 1}] = {mas[i]} ");
            }

            
            int min = mas[0];
            int max = mas[0];

            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                }
                else if (mas[i] > max)
                {
                    max = mas[i];
                }
            }

            Console.WriteLine("\n\nMax vērtība: " + max);
            Console.WriteLine("Min vērtība: " + min);
        }
    }
}
