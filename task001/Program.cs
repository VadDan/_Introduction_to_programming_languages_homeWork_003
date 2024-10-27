// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212--> нет
// 23432--> да
// 12821--> да

int GetNumber(string message)
{
    Console.WriteLine($"Введите пятизначное число : {message}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int num = GetNumber("");

if (num > 9999 && num < 100000)
{
    int num1 = num / 10000;
    int num2 = (num % 10000) / 1000;
    int num3 = (num % 1000) / 100;
    int num4 = (num % 100) / 10;
    int num5 = num % 10;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine("Это число палиндром");
    }
    else
    {
        Console.WriteLine("Это число не палиндром");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}
