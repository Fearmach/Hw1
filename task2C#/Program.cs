﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (max < num2) max = num2;
if (max < num3) max = num3;

System.Console.Write($"Максимальное из трех чисел: {max}");