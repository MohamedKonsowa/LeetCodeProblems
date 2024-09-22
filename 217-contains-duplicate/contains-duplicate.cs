public class Solution {
    public bool ContainsDuplicate(int[] nums) 
    {
        Dictionary<int ,int>dict = new Dictionary<int,int>();
        foreach(var n in nums)
        {
            if(dict.ContainsKey(n)) return true;

            dict[n] =1;
        }

        return false;
    }
}