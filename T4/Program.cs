using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 8, 4, 7, 9, 5 };

            foreach(int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
            SelectionSort.selectionSort<int>(arr);
            foreach (int num in arr)
            {
                Console.Write(num +" ");
            }
            Console.WriteLine("\n");



        }


    }
    class SelectionSort
    {


        public static void selectionSort<T>(T[] array)
        {
            for ( int i = 0; i < array.Length; i++)
            {
                T min = array[i];               
                int  minId = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    
                    
                    if (array[j] < min)
                    {
                        min = array[j];
                        minId = j;
                    }
                    
                }
                // swapping
                T temp = array[i];
                array[i] = min;
                array[minId] = temp;
            }
        }
    }
}
