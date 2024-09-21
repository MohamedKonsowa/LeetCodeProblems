public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string[]? samples = s.Trim().Split(' ');

        return samples[^1].Length;
    }
}