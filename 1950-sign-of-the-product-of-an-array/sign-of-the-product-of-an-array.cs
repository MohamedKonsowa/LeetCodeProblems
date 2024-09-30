public class Solution
{
    public int ArraySign(int[] nums)
    {
        int negativeCount = 0;

        foreach (int num in nums)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num < 0)
            {
                negativeCount++;
            }
        }

        return negativeCount % 2 == 0 ? 1 : -1;
    }
}