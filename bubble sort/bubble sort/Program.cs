using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 34, 56, 22, 67, 75, 45 };
            int num;
            for (int j = 0; j < array.Length-1; j++)
            { 
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    num = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = num;

                }


            }
        }
            Console.WriteLine("after sort");
            foreach(int j in array)
            {
                Console.Write(j + " ");
            }
        }
    }
}
