using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The First Number : ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Enter The Second Number : ");
            int j = int.Parse(Console.ReadLine());
            Console.Write("Enter The Second Number : ");
            int k = int.Parse(Console.ReadLine());

            SwapThreeNumbers.SwapNumbers(i, j, k);
        }
    }
}
