//5.С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a,b,c;
System.Console.Write("Введите первое число ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число ");
b=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число ");
c=Convert.ToInt32(Console.ReadLine());
int Max;

Max=a;

if (b>a)
{
Max=b;
}
if (c>b)
{
Max=c;
}
System.Console.WriteLine($"Вывод {Max} ");
