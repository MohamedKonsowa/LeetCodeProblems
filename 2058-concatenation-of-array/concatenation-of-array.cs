public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        List<int> result = new(nums);

        result.AddRange(nums);

        return [.. result];
    }
}