//36.Написать программу вычисления произведения чисел от 1 до N
int N=int.Parse(Console.ReadLine());
int Proizvedenie(int N)
{
    int S=1;
for(int i=1;i<=N;i++)
    S=S*i;
    return S;
}
System.Console.Write($"{Proizvedenie(N)}");