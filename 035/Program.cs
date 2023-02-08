//35.Подсчитать сумму цифр в числе. Сделать подпрограмму.
int n=123;

System.Console.WriteLine($"s{SumDigiths()}");

int SumDigiths(int n=123)
{
int s=0;
while (n!=0)
{
    s=s+n%10;
    n=n/10;
}
return s;
}
