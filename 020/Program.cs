// 20. Дано число. Проверить кратно ли оно 7 и 23
System.Console.Write("Введите число: ");
int a = Int32.Parse(Console.ReadLine());
bool b1 = a%7 == 0;
bool b2 = a%23 == 0;
if (b1 && b2)
{
    System.Console.WriteLine($"{a} кратно 7 и 23");
}
else
{
    if (b1) System.Console.WriteLine($"{a} кратно 7");
    else 
    {
        if (b2) System.Console.WriteLine($"{a} кратно 23");
        else System.Console.WriteLine($"{a} не кратно ничему");
    }
}