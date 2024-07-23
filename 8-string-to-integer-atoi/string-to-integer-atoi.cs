public class Solution
{
    public int MyAtoi(string s)
    {
        s = s.Trim();
        if (s.Length == 0 || (s[0] != '-' && s[0] != '+' && !char.IsNumber(s[0]))) return 0;

        StringBuilder stringBuilder = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (!char.IsNumber(s[i]) && stringBuilder.Length > 0)
                break;
            else if (char.IsNumber(s[i]) || (stringBuilder.Length == 0 && (s[i] == '-' || s[i] == '+')))
                stringBuilder.Append(s[i]);
        }

        bool isNegative = stringBuilder[0] == '-';
        if (isNegative || stringBuilder[0] == '+') stringBuilder[0] = '0';

        s = stringBuilder.ToString();
        s = s.TrimStart('0');

        if (s.Length == 0) return 0;

        if (s.Length > 10)
            return isNegative ? int.MinValue : int.MaxValue;

        long number = Convert.ToInt64(s);

        if (number > int.MaxValue)
            return isNegative ? int.MinValue : int.MaxValue;
        else
            return isNegative ? (int)number * -1 : (int)number;
    }
}