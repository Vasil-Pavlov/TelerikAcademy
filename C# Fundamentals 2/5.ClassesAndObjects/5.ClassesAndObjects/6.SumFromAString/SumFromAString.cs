using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumFromAString
{
    class SumFromAString
    {
        public static int Sum(string number)
        {
            string[] numbers = number.Split(' ');
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += Int32.Parse(item);
            }
            return sum;
        }

        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(Sum(number));
        }
       
    }
}
