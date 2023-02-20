
int digit =123;
System.Console.WriteLine(Sum(digit));
int Sum(int N)
{
if (N==0) return 0;
return N%10 +Sum(N/10);
}