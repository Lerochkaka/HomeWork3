/*
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

void Palindrome(int number)
{
    int count = 1;
    int length = number.ToString().Length;
    double degree = Math.Pow(10, (length - 1));
    int degree1 = Convert.ToInt32(degree);
    while(count <= (length / 2))
     {
        if(number % 10 == number / degree1)
        {
            number = number % 10 / degree1;
            count++;
            if(number <= 9)
            {
                Console.WriteLine($"Your number is a palindrome");
            }
        }
        else
        {
            Console.WriteLine($"The number {number} is not a palindrome");
        }
        break;
     }
}

Console.Write("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);

*/

/*
//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double FindDistance(double ax, double ay, double az, double bx, double by, double bz)
{
    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
}
Console.Write("Введите коордитану X точки A: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Y точки A: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Z точки A: ");
double az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Точка A будет иметь координаты ({ax}, {ay}, {az}).");
Console.Write("Введите коордитану X точки B: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Y точки B: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордитану Z точки B: ");
double bz = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Точка B будет иметь координаты ({bx}, {by}, {bz}).");
Console.WriteLine($"Расстояние между точкой A({ax}, {ay}, {az}) и точкой B({bx}, {by}, {bz}) примерно равно равно {Math.Round(FindDistance(ax, ay, az, bx, by, bz), 2)}.");

*/

/*
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void FindCubeOfNumbers(int number)
{
    int count = 1;
    while(count <= number)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
}
Console.WriteLine("Input a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindCubeOfNumbers(number);
if(number <= 0) 
{
    Console.Write("Incorrect input");
}

*/