//56 Написать программу копирования массива
int[] a;
a=new int[4];
int [] b;
b=new int [a.Length];
Array.Copy(a,b,a.Length);


Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(100,999);
for(int i=0;i<a.Length;i++)

    System.Console.Write($"{a[i]} ");
System.Console.WriteLine();    

