public class Solution
{
    public int ArraySign(int[] nums)
    {
        if(nums.Any(n=>n==0)) return 0;
        else if(nums.Count(n=>n<0)% 2 == 0) return 1;
        else return -1;
    }
}