public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int maxRight = arr[^1];
        int temp;
        arr[^1] = -1;
        for (int i = arr.Length - 2; i >= 0; i--)
        {
            temp = arr[i];
            arr[i] = maxRight;
            maxRight = Math.Max(maxRight, temp);
        }

        return arr;
    }
}