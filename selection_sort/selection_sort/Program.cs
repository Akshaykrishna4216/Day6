// selection sort
using System;
using System.Globalization;

namespace selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 45, 2, 52, 18, 67, 12, 62 };
            int num, smallest;
            for (int i = 0; i < array.Length ; i++)
            {
                smallest = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }

                    num = array[smallest];
                    array[smallest] = array[i];
                    array[i] = num;

                }
            for (int i= 0;i<array.Length;i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
          

        
    

