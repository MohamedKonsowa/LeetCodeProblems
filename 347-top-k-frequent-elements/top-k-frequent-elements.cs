public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int>? freqArray = [];

        foreach (int n in nums)
        {
            if (freqArray.ContainsKey(n))
            {
                freqArray[n]++;
            }
            else
                freqArray.Add(n, 1);
        }
        return freqArray.OrderByDescending(k => k.Value).Select(k => k.Key).Take(k).ToArray();
    }
}