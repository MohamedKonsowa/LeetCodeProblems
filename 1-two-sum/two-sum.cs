public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        HashSet<int> hashSet = new HashSet<int>();
        int n;
        for (int i = 0; i < nums.Length; i++)
        {
            n = target - nums[i];
            if (hashSet.Contains(n))
            {
                return [Array.IndexOf(nums, n), i];
            }

            hashSet.Add(nums[i]);
        }
        throw new ArgumentException("No two sum solution");
    }
}