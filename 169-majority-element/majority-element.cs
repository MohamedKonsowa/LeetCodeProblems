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

        foreach (var item in dict)
        {
            if (item.Value > nums.Length / 2)
            {
                return item.Key;
            }
        }

        return -1;
    }
}