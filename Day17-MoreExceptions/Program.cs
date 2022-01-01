class Solution{
    static void Main(string[] args){
        Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try{
                int ans=myCalculator.Power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e){
               Console.WriteLine(e.Message);

            }
        }
    }
}

class Calculator
{
    public int Power(int n, int p)
    {
        return (n < 0 || p < 0)? throw new Exception("n and/or p should be non-negative") 
        : (int)Math.Pow(n, p);
    }
}