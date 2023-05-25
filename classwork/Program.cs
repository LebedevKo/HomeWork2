// написать прогу, которая выдает случайное число от 10 до 99
// и показывает наибольшую цифру из этого числа
// 1. генерация случайного числа
// 2. найти наибольшую цифру из этого чиса
// 3. вывод этого числа
/*
Random rand = new Random();
int number = rand.Next(10, 100);
int a = number / 10;
int b = number % 10;
if (a > b)
{
    Console.WriteLine($"Our number is {number}. {a} > {b}. Result {a}");
}
else if (a < b)
{
    Console.WriteLine($"Our number is {number}. {b} > {a}. Result {b}");
}
else 
{
    
    Console.WriteLine($"Our number is {number}. {a} = {b}");
}
*/


// написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// т.е. будет выводить первую и последнюю цифру
/*
Random rand = new Random();
int number = rand.Next(100, 1000);
int a = number / 100;
int b = number % 10;

Console.WriteLine($"Our number is {number}. Result {a}{b}");

*/

//написать прогу, которая на вход принимает два числа и проверяет
// является ли одно число квадратом другого
/*
Console.WriteLine("введите  первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

//if (b == a * a) 
if (b == (a * a) || a == (b * b))
{
    Console.WriteLine("одно из чисел является квадратом другого числа");
    //Console.WriteLine($"число {b} является квадратом числа {a}");

}
//else if (a == b * b)
//{
    //Console.WriteLine("первое число является квадратом второго числа");
    //Console.WriteLine($"число {a} является квадратом числа {b}");
//}

else
{
    Console.WriteLine("нет взаимных квадратов");
}

*/

// написать прогу, которая принимает на вход два числа и проверяет 
// является ли одно число кратно другому (в обе стороны)
// если не кратно, то выводить остаток от деления

/*
Console.WriteLine("введите  первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());


if (b % a == 0 || a % b == 0)
{
    Console.WriteLine("одно из чисел кратно другому");
    //Console.WriteLine($"число {b} является квадратом числа {a}");
}
else 
{
    Console.WriteLine($"остаток от деления числа {a} на {b} равно {a % b}");
}
*/

// написать прогуБ которая принимает на вход число и проверяет кратно ли оно  одновременно 23 и 7

/*
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("да, число кратно");
}
else 
{
    Console.WriteLine("нет, не кратно");
}

*/