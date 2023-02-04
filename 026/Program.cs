// 26. Программа проверяет пятизначное число на палиндромом. Например: 12321
System.Console.WriteLine("Введите число: ");
string digit1 = System.Console.ReadLine();
int length = digit1.Length;
char[] reverse = digit1.ToCharArray();
Array.Reverse(reverse);
string digit2 = new string(reverse);
if (digit1 == digit2) System.Console.WriteLine($"{digit1} является полиндромом");
else System.Console.WriteLine($"{digit1} не является полиндромом");
