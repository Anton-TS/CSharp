// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine($"Введите три числа: ");

int [] array = { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};

int max = array[0];

for ( int i = 1; i < array.Length; i++)
{
    if (array[i] > max )
    {
        max = array[i];
    }
}

System.Console.WriteLine($"Максимальное число: {max}");