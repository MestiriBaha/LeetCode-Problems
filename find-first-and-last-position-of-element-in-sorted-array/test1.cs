using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblem
{
     public class test1
    {
        static void Main(string[] args)
        {
            foreach (int term in Solution.SearchRange(new int[] { 1, 2, 3, 4, 4, 7, 7, 8 }, 4))
            {
                Console.WriteLine(term);
            }
        }
    }
}
