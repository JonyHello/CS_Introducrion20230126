// Вывести на экран числа от -N до N
int i=-10;
int N=10;
System.Console.Write("Введите число:");
N=Convert.ToInt32(Console.ReadLine());

while(i<=N)
{
  System.Console.WriteLine(i);
  i=i+1;   
}