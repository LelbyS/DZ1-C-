// написать программу, каторая на вход принимает число N, а на выходе показывает четные числа от 1 до N
Console.Write("Введите число N=");
int N=int.Parse(Console.ReadLine());

int n=1;

while (n<=N)
{
    if (n%2==0)
    {
        Console.Write(n+" ");
    }
    n++;
}


