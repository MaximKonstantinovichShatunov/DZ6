﻿// SЗадача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1, y = k2 * x + b2  => x = (b2-b1)/(k1-k2)


Console.WriteLine ("Введите значения прямой b1: ");
double b1 = double.Parse(Console.ReadLine()); 
Console.WriteLine ("Введите значения прямой k1: ");
double k1 = double.Parse(Console.ReadLine()); 

Console.WriteLine ("Введите значения прямой b2: ");
double b2 = double.Parse(Console.ReadLine()); 
Console.WriteLine ("Введите значения прямой k2: ");
double k2 = double.Parse(Console.ReadLine()); 

// y = k1 * x + b1, y = k2 * x + b2  => x = (b2-b1)/(k1-k2)
double x = (b2-b1)/(k1-k2);
double y = k2 * x + b2;
Console.WriteLine((x, y));