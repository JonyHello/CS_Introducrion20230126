//31. Вывести на экран кубы чисел от 1 до N
Random random=new Random();
for (int i=0;i<10;i++);
{
    int a=random.Next(1,5);
    int b=(int)Math.Pow(a,3);

    System.Console.WriteLine($"Рандомное число {a}, Куб числа {b}");
}