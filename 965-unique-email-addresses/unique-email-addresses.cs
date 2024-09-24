public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        HashSet<string> uniqueEmails = [];
        StringBuilder sb;
        int i = 0;
        foreach (string email in emails)
        {
            string[]? strings = email.Split('@');
            sb = new(strings[0]);
            i = 0;
            while (i < sb.Length)
            {
                if (sb[i] == '+')
                {
                     sb  = new(sb.ToString()[..i]);

                    break;
                }
                else if (sb[i] == '.')
                {
                    sb.Remove(i, 1);
                    continue;
                }

                i++;
            }
            sb.Append('@');
            sb.Append(strings[1]);
            uniqueEmails.Add(sb.ToString());
        }

        return uniqueEmails.Count;
    }
}