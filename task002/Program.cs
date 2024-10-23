// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,7), --> 15.84
// A (7,5,0); B (1, 1,9) --> 11.53

int GetNumber(string message)
{
System.Console.WriteLine($"Введите координаты {message}: ");
int num = int.Parse(Console.ReadLine());
return num;
}
int numX1 = GetNumber("X1");
int numY1 = GetNumber("Y1");
int numZ1 = GetNumber("Z1");
int numX2 = GetNumber("X2");
int numY2 = GetNumber("Y2");
int numZ2 = GetNumber("Z2");

int numX = numX2 - numX1;
int numY = numY2 - numY1;
int numZ = numZ2 - numZ1;

double distance = Math.Sqrt(Math.Pow(numX, 2) + Math.Pow(numY, 2) + 
Math.Pow(numZ, 2));

System.Console.WriteLine(distance);