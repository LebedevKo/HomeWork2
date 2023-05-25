Console.WriteLine("Введите цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber >= 1 && dayNumber <= 7)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("да, это выходной день.");
    }
    else
    {
        Console.WriteLine("нет, это рабочий день.");
    }
}
else
{
    Console.WriteLine("Некорректный номер дня недели.");
}