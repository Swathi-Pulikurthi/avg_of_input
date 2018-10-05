using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avg_of_input
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            float sum = 0;
            int[] a = new int[100];
            Console.WriteLine("Enter the count of numbers you want to find the average of");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter " + count + " input values");
            while(i<count)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum = sum + a[i];
                i++;
                    }
            Console.WriteLine("sum of given values is " + sum);
            float avg = (sum / count);
            Console.WriteLine("average of given values is " + avg);
        }
    }
}
