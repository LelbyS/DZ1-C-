// Напишите программу, каторая принимает на вход три числа и выдает максимальное из этих чисел
Console.Write("введите первое число ");
int number1=int.Parse(Console.ReadLine());

Console.Write("введите второе число ");
int number2=int.Parse(Console.ReadLine());

Console.Write("введите третье число ");
int number3=int.Parse(Console.ReadLine());

int max=number1;

if (number1>max) max=number1;
if (number2>max) max=number2;
if (number3>max) max=number3;

Console.Write("максимальное число: ");
Console.WriteLine(max);
