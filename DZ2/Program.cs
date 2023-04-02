Main();

void Main()
{
    bool isWorking = true;

    while (isWorking)
    {
        Console.WriteLine("Выберете задание: задание1, задание2, задание2_1, задание3");
        string task = Console.ReadLine();

        switch (task)
        {
            case "выход": isWorking = false;
            break;

            case "задание1": Task1();
            break;

            case "задание2": Task2();
            break;

            case "задание2_1": Task2_1();
            break;

            case "задание3": Task3();
            break;

            default: Console.WriteLine("Неверный ввод задания");
            break;
        }
    }
}

// Написать программу, каторая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа
void Task1() 
{
    
    int a = ReadInt("a");
    int b;
    
    if (a > 99 && a < 1000)
    {
        b = a%100/10;
        Console.WriteLine($"вторая цифра {b}");
    }
    else
    {
        Console.WriteLine("Число не является трехзначным");
    }
}

// Написать программу, каторая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
void Task2() 
{
    int a = ReadInt("a");

    char[] array = a.ToString().ToCharArray();
    
    int n = array.Length;

    if (n < 3)
    {
        Console.WriteLine("третьей цифры несуществует");
    }
    else
    {
        Console.WriteLine(array[2]);
    } 
}

void Task2_1()
{
    int a = ReadInt("a");

    if (a < 100) 
    {
    Console.WriteLine("третьей цифры несуществует");
    }
    else
    {
        while ( a > 999)
        {
            a = a / 10;
        }
        Console.WriteLine(a % 10);
    }

}

// Написать программу, каторая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
void Task3()
{
 bool task3 = true;

    while (task3)
    {
        Console.WriteLine("введите день недели:");
        string n = Console.ReadLine();

        switch (n)
        {
            case "выход": task3 = false;
            break;

            case "1": Console.WriteLine("Понедельник - будний день");
            break;

            case "2": Console.WriteLine("Вторник - будний день");
            break;

            case "3": Console.WriteLine("Среда - будний день");
            break;

            case "4": Console.WriteLine("Четверг - будний день");
            break;

            case "5": Console.WriteLine("Пятница - будний день");
            break;

            case "6": Console.WriteLine("Суббота - выходной день");
            break;

            case "7": Console.WriteLine("Воскресенье - выходной день");
            break;

            default: task3 = false; Console.WriteLine("такого дня недели не существует");
            break;
        }
    }
}

int ReadInt(string argument)
{
	int number;

	Console.Write($"Введите {argument}:");

	while (!int.TryParse(Console.ReadLine(), out number))
	{
		Console.WriteLine("Это не число!!!");
	}

	return number;
}