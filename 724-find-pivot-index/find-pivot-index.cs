public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int sum = nums.Sum();
        float tempSum = 0;
        float n;
        for (int i = 0; i < nums.Length; i++)
        {
            n = (sum - nums[i]) / 2F;

            if (tempSum == n) return i;

            tempSum += nums[i];
        }

        return -1;
    }
}