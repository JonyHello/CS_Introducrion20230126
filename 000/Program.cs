// С клавиатуры вводятся 2 числа.Найти и вывести их сумму

int a,b,sum;
System.Console.Write("Введите А:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Б:");
b=Convert.ToInt32(Console.ReadLine());
sum=a+b;
//1. Конкатенация (склеивание строк)
System.Console.WriteLine(a+"+"+b.ToString()+"="+Convert.ToString(sum));
//2. Форматированный вывод
System.Console.WriteLine("{0:F1}+{1:E2}={2:G3}",a,b,sum);
//3. Интерполяция строк 
System.Console.WriteLine($"{a}+{b}={sum}");


// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
int max;
max=a;
if (b>a)
{
max=b;
}
System.Console.WriteLine($"max={max}");