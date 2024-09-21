public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        if (arr.Length == 1)
        {
            arr[0] = -1;
            return arr;
        }

        int maxRight = Math.Max(arr[^1], arr[^2]);
        int temp;
        arr[^2] = arr[^1];
        arr[^1] = -1;
        for (int i = arr.Length - 3; i >= 0; i--)
        {
            temp = arr[i];
            arr[i] = maxRight;
            maxRight = Math.Max(maxRight, temp);
        }

        return arr;
    }
}