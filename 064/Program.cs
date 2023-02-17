
//64. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению 

int[,] Random2DArray (int N,int M,int min,int max)
{
int [,] a = new int[N,M];
Random random=new Random();
for (int i=0;i<a.GetLength(0);i++)
    for (int j=0;j<a.GetLength(0);j++)
    a[i,j]=random.Next(min,max+1);
    return(a);
}

void Print2DArry(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
            for (int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j],5}");
            System.Console.WriteLine();
        }
        {
            System.Console.WriteLine();
        }
}
int [,] a=Random2DArray(4,4,0,10);
Print2DArry(a);



int [,] Change2DArray(int[,] a)
{
    int[,] NewArray = new int [a.GetLength(0),a.GetLength(1)];
    for (int i=0;i<a.GetLength(0);i++)
    {
        for (int j=0;j<a.GetLength(1);j++)
        {
            if (i%2 == 0 || j%2 == 0) NewArray[i,j]= a[i,j]*a[i,j];
            else NewArray[i,j]= a[i,j];
        }
    }
return NewArray;
}

int[,] NewArray=Change2DArray(a);
Print2DArry(NewArray);