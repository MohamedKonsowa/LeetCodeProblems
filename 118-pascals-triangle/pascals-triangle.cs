public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> result = [[1]];
        List<int> temp;

        for (int i = 1; i < numRows; i++)
        {
            temp = new List<int> { 1 };
            for (int j = 1; j < i; j++)
            {
                temp.Add(result[i - 1][j - 1] + result[i - 1][j]);
            }
            temp.Add(1);
            result.Add(temp);
        }

        return result;
    }
}