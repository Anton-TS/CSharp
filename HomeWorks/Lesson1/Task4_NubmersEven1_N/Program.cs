﻿ /*Задача 4: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N. */

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 1;

if (N < count)
    {
        Console.WriteLine("Введите положительное число, которое больше нуля!");
    }

while ( count <= N)
    {
        if ( count % 2 == 0 )
                {
                    Console.Write( count + " ");
                }
            count++;
    }