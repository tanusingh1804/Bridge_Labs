using System;
using System.Collections.Generic;

class PairWithSum
{
    static bool HasPairWithSum(int[] nums, int target)
    {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in nums)
        {
            if (seen.Contains(target - num))
                return true;

            seen.Add(num);
        }

        return false;
    }

    static void Main()
    {
        int[] nums = { 1, 4, 6, 8, 10 };
        int target = 14;

        Console.WriteLine(HasPairWithSum(nums, target));
    }
}
