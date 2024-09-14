public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dictionary = [];
        int n;
        for (int i = 0; i < nums.Length; i++)
        {
            n = target - nums[i];
            if (dictionary.ContainsKey(n))
            {
                return [i, dictionary[n]];
            }

            dictionary[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
    }
}