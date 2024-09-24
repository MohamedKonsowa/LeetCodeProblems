public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        HashSet<string> uniqueEmails = [];
        StringBuilder sb;
        foreach (string email in emails)
        {
            string[]? strings = email.Split('@');
            sb = new(strings[0].Split('+')[0].Replace(".",""));

            sb.Append('@');
            sb.Append(strings[1]);
            uniqueEmails.Add(sb.ToString());
        }

        return uniqueEmails.Count;
    }
}