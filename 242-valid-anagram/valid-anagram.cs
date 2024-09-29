public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var sArray = s.ToCharArray();
        Array.Sort(sArray);
        s = new string(sArray);

        var tArray = t.ToCharArray();
        Array.Sort(tArray);
        t = new string(tArray);

        return s == t;
    }
}