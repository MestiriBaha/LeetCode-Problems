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
            int[] result = new int[2];
            List<int> list = nums.ToList();
            for (int i = 0; i < nums.Length; i++)
            {
                // we have to add the condition that the two number have to be distinct
        
                    if (list.Contains((target - list[i])) && i != list.IndexOf(target - list[i])) { result[0] = i; result[1] = list.IndexOf(target - list[i]);
                        Console.WriteLine("index i  " + i);
                        Console.WriteLine("index j  " + list.IndexOf(target - list[i]));
                        Console.WriteLine("it works "); break; }

         
          }
            return result;   
        }
    }
}
