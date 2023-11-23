
int SumInInterval(int M, int N)
{
    if(N > M )
    {
        return SumInInterval(M, N - 1) + N;

    }
    else return N;
}
System.Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumInInterval(m, n);
System.Console.WriteLine(sum);
