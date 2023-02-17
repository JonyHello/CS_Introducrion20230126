//65 Показать двумерный массив размером m×n заполненный вещественными случайными числами
int [,] Random2Darray(int N, int M,int min,int max)
{
    int[,] a=new int[N,M];
    Random random=new Random();
    for (int i=0; i<a.GetLength(0);i++)
        for (int j=0;j<a.GetLength(1);j++)
        a[i,j]=random.Next(min,max+1);
        return a;
}

void Print2DArry(int[,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],5}");
        System.Console.WriteLine();
    
    }
}

int[,] a=Random2Darray(3,4,0,10);
Print2DArry(a);
int r,c;

if (FindElemenrIn2DArray(a,10,out r,out c))
System.Console.WriteLine($"row={r} colum={c}");
else 
System.Console.WriteLine("Element not found");

bool FindElemenrIn2DArray(int [,] a, int find, out int row,out int colum)
{
     row=-1;
     colum=-1;
    for (int i=0; i<a.GetLength(0);i++)
        for (int j=0;j<a.GetLength(1);j++)
        if(a[i,j]==find)
    {
        row=i;
        colum=j;
        return true;
    }
    return false;
}


//66.Написать подпрограмму, которая в квадратной матрице чисел находит сумму элементов главной диагонали
int SumMainDiaganal (int[,] a)
{
int s=0;
for (int i=0; i<a.GetLength(0);i++)
        for (int j=0;j<a.GetLength(1);j++)
        if (i==j)
        s=s+a[i,j];
        for (int i=0; i<a.GetLength(0);i++)
        s=s+a[i,i];
        return s;
}
System.Console.WriteLine(SumMainDiaganal(a));
