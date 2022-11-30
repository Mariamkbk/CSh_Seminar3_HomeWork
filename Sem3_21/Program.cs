﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistance (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    return distance;
}
try
{
Console.WriteLine("Введите координаты точки А на оси x");    
double x1 = Convert.ToDouble(Console.ReadLine());    
Console.WriteLine("Введите координаты точки B на оси x");    
double x2 = Convert.ToDouble(Console.ReadLine());    
Console.WriteLine("Введите координаты точки А на оси y");    
double y1 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите координаты точки B на оси y");    
double y2 = Convert.ToDouble(Console.ReadLine());    
Console.WriteLine("Введите координаты точки А на оси z");    
double z1 = Convert.ToDouble(Console.ReadLine());  
Console.WriteLine("Введите координаты точки B на оси z");    
double z2 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine(FindDistance (x1,x2,y1,y2,z1,z2)); 
}
catch
{
   Console.WriteLine("Введены некорректные данные. Убедитесь, что ввели числовое значение");   
}