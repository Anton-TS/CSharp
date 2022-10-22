// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("В этом числе нет третьей цифры!");
        return false;
    }
    return true;
}

Console.WriteLine("Давайте найдем третью цифру введенного числа!");
int number = Prompt("Введите число: ");

int thirdNumber = 0;

if (ValidateNumber(number))
{
    while (number >= 1000)
    {
        number = number / 10; 
    }
    thirdNumber = number % 10;
    Console.WriteLine($"Третья цифра заданного цисла: {thirdNumber}");
}
