using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Task3_Extension_Method
{
    public static class Sort
    {
        public static void CustomSort(this int[] numbers)  //Bubble Sort
        {

            for (int i = 0; i < numbers.Length -1; i++)
            {
                for(int j = 0; j< numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j + 1]; 
                        numbers[j + 1] = temp;

                    }
                }  
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 44, 22, 33, 12, 44, 55, 12, 56, 63, 23 };
            array.CustomSort();
            Console.ReadKey();
        }
    }
}
