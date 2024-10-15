public class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        Dictionary<int, int> dict = new(nums.Count());
        List<int> result = [];

        foreach (int n in nums)
        {
            if (dict.ContainsKey(n))
                result.Add(n);
            else
                dict.Add(n, 1);
        }

        return result;
    }
}