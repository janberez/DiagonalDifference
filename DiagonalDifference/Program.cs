using System;

internal class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);
    }
}

internal class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int NumberFromLeftToRight = 0, NumberFromRightToLeft = 0;
        int collumsFromLeftToRight = 0, collumsFromRightToLeft = arr.Count-1;
        for (int rows = 0; rows < arr.Count; rows++)
        {
            NumberFromLeftToRight += arr[rows][collumsFromLeftToRight];
            NumberFromRightToLeft += arr[rows][collumsFromRightToLeft];
            collumsFromLeftToRight++;
            collumsFromRightToLeft--;
        }
        return Math.Abs(NumberFromLeftToRight - NumberFromRightToLeft);
    }
}