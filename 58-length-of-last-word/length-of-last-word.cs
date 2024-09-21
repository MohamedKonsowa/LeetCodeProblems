public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string[]? samples = s.TrimEnd().Split(' ');

        return samples[^1].Length;
    }
}