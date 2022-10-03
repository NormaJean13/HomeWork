// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"{num1} - большее число");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"{num2} - большее число");
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine($"{num3} - большее число");
}
else
{
    Console.WriteLine("Что-то не так");
}
