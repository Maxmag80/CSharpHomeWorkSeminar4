﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Input integer A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input integer B: ");
int B = Convert.ToInt32(Console.ReadLine());
int res = 1;

for (int i=1; i <= B; i++)
{
    res *= A;
}
Console.WriteLine(res);