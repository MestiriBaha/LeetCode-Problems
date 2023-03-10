using LeetcodeProblem;
public class Solution
{
     static int FirstOccurrence(int[] array, int n)
    {

        int beg = 0;
        int end = array.Length - 1;

        while (beg <= end)
        {

            int mid = beg + (end - beg) / 2;

            if (array[mid] == n)
            {
                if (mid - 1 >= 0 && array[mid - 1] == n)
                {
                    end = mid - 1;
                    continue;
                }
                return mid;
            }

            else if (array[mid] < n)
                beg = mid + 1;
            else
                end = mid - 1;
        }
        return -1;
    }
     static int LastOccurrence(int[] array, int n)
    {

        int beg = 0;
        int end = array.Length - 1;

        while (beg <= end)
        {

            int mid = beg + (end - beg) / 2;

            if (array[mid] == n)
            {
                if (mid + 1 < array.Length && array[mid + 1] == n)
                {
                    beg = mid + 1;
                    continue;
                }
                return mid;

            }

            else if (array[mid] < n)
                beg = mid + 1;
            else
                end = mid - 1;
        }
        return -1;
    }
    public static int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return new int[] { -1, -1 };
        }

        List<int> result = new List<int>();
        result.Add(FirstOccurrence(nums, target));
        result.Add(LastOccurrence(nums, target));
        return result.ToArray();

    }


}
     
   