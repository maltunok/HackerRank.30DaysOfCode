class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList()
        .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        ReversePrint(arr);
    }

    private static void ReversePrint(List<int> arr)
    {
        int length = arr.Count;

        for (int i = length-1; i >= 0; i--)
        {
            if (i != 0)
            {
                Console.Write(arr[i] + " ");
            }
            else{
                Console.Write(arr[i]);
            }
        }
    }
}