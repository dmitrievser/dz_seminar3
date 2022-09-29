
/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine());

if (number >= 10000 && number < 100000)
{
    int a = number / 1000; // 12321 (допустим наше число) / 1000 = 12
    int num1 = a / 10; // 12 / 10 = 1
    int num2 = a % 10; // 12 % 10 = 2
    int b = number % 100; // 12321 % 100 = 21
    int num4 = b / 10; // 21 / 10 = 2
    int num5 = b % 10; // 21 % 10 = 1

    if ((num1 == num5) & (num2 == num4))
    {
        Console.WriteLine ("Число палиндром!");
    }

    else
    {
        Console.WriteLine ("Число не полиндром!");
    }
}
else
{
    Console.WriteLine ("Введено не пятизначное число.");
}

--------------------------------------------------------------------------------------------------------------------

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("d = {d:f3}");


Console.Write("Введите координаты для точки x: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите координаты для точки y: ");
int y = int.Parse(Console.ReadLine());

Console.Write("Введите координаты для точки z: ");
int z = int.Parse(Console.ReadLine());

Console.Write("Введите координаты для точки x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты для точки y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты для точки z1: ");
int z1 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x,2) + Math.Pow(y1 - y,2) + Math.Pow(z1 - z,2));

Console.WriteLine($"Расстояние между точками равно: {result:f2}");

--------------------------------------------------------------------------------------------------------------------

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Число 3: Куб числа 1 (1*1*1) = 1, куб числа 2 (2*2*2) = 8, куб числа 3 (3*3*3) = 27 (ответ: 1, 8, 27)
// Число 4: Куб числа 1 = 1, куб числа 2 = 8, куб числа 3 = 27, куб числа 4 = 64 (ответ: 1, 8, 27, 64)


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)

{
    double result = Math.Pow (i, 3);
    Console.WriteLine($"{result}");
}

*/ 