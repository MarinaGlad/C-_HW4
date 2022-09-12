﻿/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите первое число ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= B; i++)
{
    result *= A;
}
Console.WriteLine(result);

/*Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{
    int digit = number % 10;
    sum = sum + digit;
    number= number/10;
}
Console.WriteLine($"Сумма цифр = {sum}");

/*Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


int[] array = new int[8];
    for (int i =0; i<array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    Console.WriteLine($"Result array: [ {String.Join(", ",array)} ]");

//Введение с консоли
Console.WriteLine("Введите цифры ");
    int[] array = new int[8];
    for (int i =0; i<array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Result array: [ {String.Join(", ",array)} ]");