//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число:  ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:  ");
int n2 = Convert.ToInt32(Console.ReadLine());



if ( n1 > n2 )  { Console.WriteLine($"{n1} больше {n2}"); }
if ( n2 > n1 )  { Console.WriteLine($"{n2} больше {n1}"); }
if ( n2 == n1 ) { Console.WriteLine($"{n1} и {n2} равны"); }