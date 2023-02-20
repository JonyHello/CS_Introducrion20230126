//78. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. Использовать рекурсию.

int Fib(int N)
{
    if (N==0) return 0;
            else
                  if (N==1) return 1;
                        return Fib(N-1)+Fib(N-2);

}
for(int i=0;i<10;i++)
System.Console.WriteLine(Fib(i));


