public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        string[]? samples = s.Split(' ');

        return samples[^1].Length;
    }
}