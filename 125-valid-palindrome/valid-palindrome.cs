public class Solution {
    public bool IsPalindrome(string str) {
        str = new(str.ToLower().Where(c => char.IsLetterOrDigit(c)).ToArray());

        string reversed = new(str.Reverse().ToArray());

        return str == reversed;
    }
}