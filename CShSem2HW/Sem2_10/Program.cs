﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

try
{
    Console.WriteLine("Введите трёхзначное число");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 99 && a < 1000)
    {
        int res = (a % 100) / 10;
        Console.WriteLine($"{res} является второй цифрой числа {a}");
    }
    else if (a < 0)
    {
        a = a * (-1);
        int res = (a % 100) / 10;
        Console.WriteLine($"{res} является второй цифрой числа -{a}");
    }
    else Console.WriteLine("Введенное Вами число не является трёхзначным");
}
catch 
{
    Console.WriteLine("Введены некорректные символы. Пожалуйста, вводите только числовое значение.");
}