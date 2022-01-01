public interface IAdvancedArithmetic{
    int DivisorSum(int n);
}
public class Calculator : IAdvancedArithmetic
{
    public int DivisorSum(int n)
    {
        var sum  = 0;
        for (var i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}

class Solution{
    static void Main(string[] args){
        int n = Int32.Parse(Console.ReadLine());
      	IAdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.DivisorSum(n);
        Console.WriteLine("I implemented: IAdvancedArithmetic\n" + sum); 
    }
}