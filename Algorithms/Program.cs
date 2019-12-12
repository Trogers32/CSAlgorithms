using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //Given an integer number n, return the difference between the product of its digits and the sum of its digits.
    public class Solution
    {
        public int SubtractProductAndSum(int n)
        {
            int digit, sum = 0, prod = 1, temp = Math.Abs(n);
            if (n <= 0)
            {
                return 0;
            }
            while (temp != 0)
            {
                digit = temp % 10;
                sum += digit;
                prod *= digit;
                temp /= 10;
            }
            return prod - sum;
        }
    }
}
