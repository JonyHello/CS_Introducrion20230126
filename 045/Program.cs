//45.Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] a;
a=new int[4];

Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(100,999);
for(int i=0;i<a.Length;i++)

    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();    



foreach (int c1 in a)
if (c1%2==0)
System.Console.WriteLine($"Четные числа {c1}");



foreach (int c2 in a)
if (c2%2!=0)
System.Console.WriteLine($"Нечетные числа {c2}");
