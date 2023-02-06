//33.Возведите число А в натуральную степень B используя цикл
System.Console.Write("Введите число: ");
int a = Int32.Parse(System.Console.ReadLine());
System.Console.Write("Введите необходимую степень: ");
int b = Int32.Parse(System.Console.ReadLine());

double digitPow(double x, double y)
{
    double d = 1;
    for(int i = 1; i <= y; i++)
    {
        d = d*x;
    }
    return d;
}
System.Console.WriteLine(digitPow(a,b));