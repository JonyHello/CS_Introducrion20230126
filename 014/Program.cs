// 14. С клавиатуры вводятся два числа a и b.
// Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
System.Console.Write("Введите число a: ");
int a = Int32.Parse(System.Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = Int32.Parse(System.Console.ReadLine());
if (a % b == 0)
    System.Console.WriteLine("a кратно b");
else
    System.Console.WriteLine(a % b);