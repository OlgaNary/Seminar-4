﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
System.Console.WriteLine("Введите число A:");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B:");
int numB = Convert.ToInt32(Console.ReadLine());

GetDegree(numA, numB);

void GetDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"{a} в степени {b} = {result}");
}

