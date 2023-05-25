
Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();

if (numberStr.Length >= 3)
{
    char thirdDigit = numberStr[2];
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
else
{
    Console.WriteLine("У числа нет третьей цифры.");
}