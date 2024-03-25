namespace LeetCode217Solution
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var map = new HashSet<int>();

            return nums.Any(num => !map.Add(num));
        }
    }
}
