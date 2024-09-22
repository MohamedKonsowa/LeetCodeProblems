public class Solution {
      public bool ContainsDuplicate(int[] nums) 
        => nums.GroupBy(n => n).Any(g => g.Count() > 1);
}