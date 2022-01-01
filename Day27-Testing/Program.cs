class Solution
{
    public static void Main(string[] args)
    {
        
    }
    public static int[] GetArray()
    {
        return new int[];
    }
}

public static class TestDataUniqueValues
{
    static int[] seq  = new int [] {1, 2, 3, 4, 5};

    public static int[] GetArray()
    {
        return seq;
    }

    public static int GetExpectedResult()
    {
        return 0;
    }
}

public static class TestDataExactlyTwoDifferentMinimums
{
    static int[] seq  = new int [] {1, 1, 2};

    public static int[] GetArray()
    {
        return seq;
    }

    public static int GetExpectedResult()
    {
        return 0;
    }
}