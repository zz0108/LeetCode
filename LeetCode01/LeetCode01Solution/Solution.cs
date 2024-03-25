using System;

namespace LeetCode01Solution
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var index = target - nums[i];

                if (map.TryGetValue(index, out var value)) return [value, i];
                map.TryAdd(nums[i], i);
            }

            return [-1, -1];
        }
    }
}
