public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dict = [];
        string sortedString;
        char[] chars = [];
        List<IList<string>> result = [];

        List<string> list = [];
        foreach (string str in strs)
        {
            chars = str.ToCharArray();
            Array.Sort(chars);
            sortedString = new string(chars);
            if (dict.ContainsKey(sortedString))
            {
                dict[sortedString].Add(str);
            }
            else
            {
                dict.Add(sortedString, [str]);
            }
        }

        foreach (var item in dict)
        {
            result.Add(item.Value);
        }

        return result;
    }
}