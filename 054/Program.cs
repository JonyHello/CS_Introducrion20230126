//54 С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
System.Console.WriteLine("Введите число: ");
int N=int.Parse(Console.ReadLine());
int[] a = new int [N];

Fibbonachi(a);
printArray(a);


void Fibbonachi(int[]arr)
{
    int k=0;
    System.Console.WriteLine("Введите первые 2 числа");
    for (int i=0;i<2;i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
        k++;
    }
    fib(arr,k);
}

void fib (int [] arr, int j)
{
    for (int i = j;i<a.Length;i++)
    {
        arr[i]=arr[i-2]+arr[i-1];
    }
}
void printArray(int[] arr)
{
    for(int i = 0;i < arr.Length;i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
