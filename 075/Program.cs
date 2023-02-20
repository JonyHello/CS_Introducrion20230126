//75 Написать программу вычисления функции Аккермана - 5*

int n = 4;
int m = 4;

int Ackerman(int n, int m)
{
    if (n == 0) return m+1;
    else
        if(m == 0) return Ackerman(n-1,1);
            else 
                return Ackerman(n-1,Ackerman(n,m-1));
}

for(int i = 0; i < n;i++)
{
    for(int j = 0;j<m;j++)
    {
        System.Console.Write($"{Ackerman(j,i),4}");
    }
    System.Console.WriteLine();
}