public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1) return strs[0];
        Array.Sort(strs);
        int length = Math.Min(strs[0].Length, strs[^1].Length);
        StringBuilder sb = new StringBuilder();
        for (int i = 0;i<length;i++ )
        {
            if(strs[0][i] == strs[^1][i])
            {
                sb.Append(strs[0][i]);
            }
            else
            {
                break;
            }
        }

        return sb.ToString();
    }
}