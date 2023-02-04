// 22. По двум заданным числам проверять является ли одно квадратом другого
System.Console.Write("Введите первое число: ");
int a1 = Int32.Parse(System.Console.ReadLine());
System.Console.Write("Введите второе число: ");
int a2 = Int32.Parse(System.Console.ReadLine());
if (a1 == a2*a2) System.Console.WriteLine($"{a1} является квадратом {a2}");
else
{
    if (a2 == a1*a1) System.Console.WriteLine($"{a2} является квадратом {a1}");
    else System.Console.WriteLine("Ни одно число не является квадратом другого");
}