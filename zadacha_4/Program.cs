﻿// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// Исходные значения:
Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
int y = 2;
// Проверка  выполнения условия задачи в принципе:
if (x <= 1)
{
    Console.WriteLine("Для данного условия нет четных чисел");
}

while (y <= x)
{
   Console.Write($"{y}, ");
    y+=2;
}