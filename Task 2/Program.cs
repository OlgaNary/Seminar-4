﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
System.Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма цифр числа равна {GetSum(number)}");

int GetSum(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}
