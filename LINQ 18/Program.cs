using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        // Вариант 2 Beginer
        // Задача 18
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, -17, 45, 67, 8, 45, -54, 4, 8, 4, 4, -7, 23, 3, 5, 6, -6, 24, -8 };
            var result2 = list1.Where(x => (x < 0) && (x % 2 == 0)).Reverse();
            foreach (int i in result2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

