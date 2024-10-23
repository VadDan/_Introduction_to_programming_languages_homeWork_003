// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 --> 1, 8, 27.
// 5 --> 1, 8, 27, 64, 125

int GetNumber(string mess)
{
    Console.WriteLine($"Введите {mess}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = GetNumber("число");
int i = 1;
while (i <= num)
{
    Console.Write(Math.Pow(i, 3));
    if (i < num)
    {
        Console.Write(", ");
    }
    i++;
}
Console.WriteLine("");
