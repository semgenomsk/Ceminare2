// Задача 12: Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n2 != 0)
{
    int ost = n1 % n2;
    if (ost == 0)
    {
        Console.WriteLine("кратно");
    }
    else
    {
        Console.WriteLine($"не кратно, остаток {ost}");
    }
}
else
{
    Console.WriteLine("Недьзя делить на ноль!");
}