class Solution {
    static void Main(string[] args) {
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.ComputeDifference();
        
        Console.Write(d.maximumDifference);
    }
}

class Difference {
    private int[] _elements;
    public int maximumDifference;

	public Difference (int[] arr)
    {
        _elements = arr;
    }

    public void ComputeDifference()
    {
        var min = int.MaxValue;
        var max = int.MinValue;

        for (int i = 0; i < _elements.Length; i++)
        {
            min = Math.Min(min, _elements[i]);
            max = Math.Max(max, _elements[i]);
        }

        maximumDifference = Math.Abs(max - min);
    }
}