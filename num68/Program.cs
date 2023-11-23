int AckermannFunc(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(m > 0 && n == 0)
    {
        return AckermannFunc(m - 1, 1);
    }
    else 
    {
        return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    }
}
System.Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunc(m , n);
System.Console.WriteLine(result);

