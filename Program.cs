﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// **********************Задача 1***************************
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int max=int.MaxValue;
// int count=0;
// for (int i = 0; i < max; i++)
// {
//     Console.WriteLine("Введите число, если закончиили ввод введите 00 ");
//     int num = Convert.ToInt32(Console.ReadLine());
    
//     if (num==00)  
//     {
//         break;
//     }
//     if (num>0)
//     {
//         count++;
//     }
// }
// Console.WriteLine("Пользователь ввел "+count+" шт. чисел больше 0");

// ***********************Конец***************************************
// **********************Задача 2**************************************
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите b1");
// double b1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2");
// double b2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k1");
// double k1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2");
// double k2=Convert.ToInt32(Console.ReadLine());

// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;
// if (x>int.MinValue&&x<int.MaxValue&&y>int.MinValue&&y<int.MaxValue)
// {
//     Console.WriteLine("Координаты точки пересечения: х="+x+" y="+y);   
// }
// else
// Console.WriteLine("Прямые не пересекаются");

// *****************Конец*******************************