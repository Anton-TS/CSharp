// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// Не использовать строки для расчета.


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number > 99 & number < 1000)
    {
        return true;
    }
    Console.WriteLine("Это не трехзначное число!");
    return false;
}
Console.WriteLine("Давайте найдем вторую цифру трехзначного числа!");
int number = Prompt("Введите число: ");

if (ValidateNumber(number))
{
    int secondNumber = 0;
    secondNumber = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра этого числа: {secondNumber}");
}    