public static  class Solution
{
    public static int SearchInsert(int[] nums, int target)
    {
        if (nums.Length == 0) { return 0; }
        if (nums.Length == 1 && nums[nums.Length - 1] != target)
        {
            if (nums[nums.Length - 1] > target) { return nums.Length - 1; }
        }
        if (nums.Length == 1 && nums[nums.Length - 1] == target)
        {
            return nums.Length - 1;
        }

        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            int middle = (left + right) / 2;
            //Console.WriteLine(middle);
            if (nums[middle] == target) { return middle; }
            if (nums[middle] < target) { left = middle + 1; }
            if (nums[middle] > target) { right = middle - 1; }
            //  Console.WriteLine(right); Console.WriteLine(left);



        }
        //  if (nums[left] == nums[right])
        if (left == nums.Length - 1 && right == nums.Length - 1) { { return left + 1; } }

        //if (nums[left] == nums.Length -1 ) { return left + 1;  }
        return left;

    }





    static public void Main(String[] args)
    {
       Console.WriteLine(SearchInsert(new int[] {1,3,5,6}, 4));
        Console.WriteLine(SearchInsert(new int[] { 1, 3, 5, 6 }, 100));


    }
}
          

