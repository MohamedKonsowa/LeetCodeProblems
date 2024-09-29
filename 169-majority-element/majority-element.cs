public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict.Add(num, 1);
            }
        }
            return dict.FirstOrDefault(x => x.Value > nums.Length / 2).Key;
    }
}