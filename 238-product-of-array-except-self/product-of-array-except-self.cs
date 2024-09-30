public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        long product = 1;
        int zeroCount = 0;
        foreach (int num in nums)
        {
            if (num == 0)
            {
                zeroCount++;
                continue;
            }
            product *= num;
        }

        int[] result = new int[nums.Length];
        if (zeroCount > 1)
        {
            return result;
        }
        else if (zeroCount == 1)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    result[i] = (int)product;
                }
            }
            return result;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = (int)(product / nums[i]);
        }
        return result;
    }
}