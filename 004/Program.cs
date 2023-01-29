//4. По заданному с клавиатуры номеру дня недели вывести его название
int a=0;
System.Console.Write("Введите номер дня ");
a=Convert.ToInt32(Console.ReadLine()); 
if (a==1)
System.Console.WriteLine("Выбронный день - Понедельник");
if (a==2)
System.Console.WriteLine("Выбронный день - Вторник");
if (a==3)
System.Console.WriteLine("Выбронный день - Среда");
if (a==4)
System.Console.WriteLine("Выбронный день - Четверг");
if (a==5)
System.Console.WriteLine("Выбронный день - Пятница");
if (a==6)
System.Console.WriteLine("Выбронный день - Суббота");
if (a==7)
System.Console.WriteLine("Выбронный день - Воскресенье");
