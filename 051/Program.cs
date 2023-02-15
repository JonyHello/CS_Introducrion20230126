//51. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

System.Console.WriteLine("Введите число N");
int N=Convert.ToInt32(Console.ReadLine());
int count=0;
System.Console.WriteLine("Введите числа:");
for (int i = 0; i<N; i++)
{
    int n=int.Parse(Console.ReadLine());
    if (n>0) count++;
}
System.Console.WriteLine($"Количество чисел больше 0: {count}");
