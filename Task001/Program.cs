// напишите программу, каторая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.Write("введите первое число a: ");
int a=int.Parse(Console.ReadLine());
Console.Write("Введите второе число b: ");
int b=int.Parse(Console.ReadLine());

if (a>b)
{
    Console.Write("максимальное число a= ");
    Console.WriteLine(a);
    Console.Write("минимальное число b= ");
    Console.WriteLine(b);
}
else
{ 
    if (a==b)
    {
        Console.Write(" числа равны b=a=");
        Console.WriteLine(b);
    }
    else
    {
        Console.Write("максимальное число b= ");
        Console.WriteLine(b);
        Console.Write("минимальное число a= ");
        Console.WriteLine(a);
    }
}