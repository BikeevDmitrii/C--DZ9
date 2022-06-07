/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/
int sum(int M, int N)
{
    if (M == N)
        return M;
    if (M <= N)
    {
        M = M + sum(M+1, N);
        return M;
    }
     else
        N = N + sum(M, N+1);
        return N;       
};
Console.WriteLine("Введите начальное число:");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Промежуточные данные:");
Console.WriteLine($"Сумма цифр от {M} до {N} = {sum(M, N)}");
