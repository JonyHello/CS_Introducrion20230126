//10.Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
System.Console.Write("Введите число: ");
int a = Int32.Parse(System.Console.ReadLine());
int b;
b = a % 10;
System.Console.WriteLine("Последняя цифра: "+ b);