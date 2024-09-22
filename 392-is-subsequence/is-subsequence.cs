public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if(s.Length > t.Length) return false;
        if(s == string.Empty) return true;

        int i = 0;
        foreach(var c in t)
        {
            if (s[i] == c)
                i++;
            if (i == s.Length)
                return true;
        }

        return false;
    }
}