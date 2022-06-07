/*
Задача 64: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

static int summ(int i, int a)
{
    if (i >= 10)
    {
        a = a + i % 10;
        i = i / 10;
        return summ(i, a);
    }

    else 
        return a = a + i;
}
Console.WriteLine("Введите число:");
int i = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {i} = {summ(i, 0)}");
