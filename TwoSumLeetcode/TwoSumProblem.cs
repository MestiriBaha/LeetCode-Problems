using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumLeetcode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2] ;
           ; int j = 1;
            int x = nums.Length; 
            while(j<x)
            {
                for ( int i=0 ; i<nums.Length; i++)
                {
                    Console.WriteLine(" nums de j " + nums[j]);
                    Console.WriteLine("nums de i " + nums[i]);
                    int y = nums[i] + nums[j]; Console.WriteLine(y);
                    if (y == target) { Console.WriteLine("finally"); result[0] = i; result[1] = j; break;  }
                }
                j++;
            }
            Console.WriteLine(result[0] );
            Console.WriteLine(result[1]);

            return result; 
        }
    }
}
