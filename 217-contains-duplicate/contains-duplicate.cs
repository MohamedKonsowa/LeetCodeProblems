public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new();
            foreach (var n in nums)
            {
                if (set.Contains(n)) return true;

                set.Add(n);
            }

            return false;
        }
    }