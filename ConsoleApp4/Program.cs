using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, -3, 5 };
            var posNums = from n in nums orderby n descending select n * 4 / 2;
            Console.Write("nilai: ");
            foreach (int i in posNums)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
