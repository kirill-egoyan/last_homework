void ShowNums(int n)
{
    if(n > 0)
    {
        System.Console.Write(n + " ");
        ShowNums(n - 1);
        
    }
}
System.Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
