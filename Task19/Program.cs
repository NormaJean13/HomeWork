// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
void Palindrom(int n1)
{
    while (n1 > -10000 && n1 < 10000 || n1 > 99999 || n1 < -99999)
    {
        Console.Write("Введите пятизначное число: ");
        n1 = Convert.ToInt32(Console.ReadLine());
    }
    int first = n1 / 10000;
    int second = n1 % 10;
    if (first == second)
    {
        first = n1 / 1000 % 10;
        second = n % 100 / 10;
        if (first == second) Console.Write($"Число {n1} - палиндром.");
        else Console.Write($"Число {n1} - не является палиндромом.");
    }
    else
        Console.Write($"Число {n1} - не является палиндромом.");
}
Palindrom(n);