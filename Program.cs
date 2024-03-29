﻿//**********************************************************
//* Практическая работа №4                                 *
//* Выполнил Здор Г. В., группа 2ИСП                       *
//* Задание: составить программу работы линейного алгоритма*
//**********************************************************

using System;
using System.Runtime.CompilerServices;

namespace PR_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №4"; //заголовок консоли

            double x = 7, b = 5, Y; // объявление переменных
            double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22; 

            // расчёт значения выражения
            v1 = b - 1;
            v2 = b * x;
            v3 = 1 - v2;
            v4 = v1 / v3;
            v5 = Math.Pow(x, 3); // возведение в степень
            v6 = v5 + 1;
            v7 = v5 - b;
            v8 = v6 / v7;
            v9 = v4 / v8;
            v10 = Math.Pow(x, 2); // возведение в степень
            v11 = 17 * b * x;
            v12 = v10 - v11 + 7;
            v13 = Math.Pow(x, b); // возведение в степень
            v14 = 2 * v13;
            v15 = v14 + 5;
            v16 = Math.Sqrt(v15); // корень
            v17 = 3 * v16;
            v18 = v17 - x;
            v19 = v11 / v18;
            v20 = Math.Abs(v19); // модуль числа
            v21 = Math.Log10((double)v20); //десятичный логарифм
            v22 = 3 * v21;

            Y = v19 + v22;

            // вывод результата на экран
            Console.WriteLine("Результат: Y = " + Y);
            Console.ReadKey(); // задержка экрана консоли
        }
    }
}
