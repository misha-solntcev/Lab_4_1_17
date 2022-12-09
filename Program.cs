using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*17. Заполнить массив А[1..8] числами, вводимыми с клавиатуры. 
    Найти среднее арифметическое положительных элементов.*/

namespace Lab_4_1_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8] { 1, -2, 3, 4, 5, -6, -7, -8 };

            // Классический способ:
            double sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)                            
                if (arr[i] > 0)
                {
                    sum += arr[i];
                    count++;
                }            
            Console.WriteLine($"Среднее арифметическое положительных элементов = {sum/count}");

            // С использованием Linq:
            double sred = (double)arr.Where(x => x > 0).Sum() / arr.Where(x => x > 0).Count();
            Console.WriteLine($"Среднее арифметическое через Linq = {sred}");

            Console.ReadKey();
        }
    }
}
