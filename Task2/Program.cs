﻿// 11. Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random Rand=new Random();
int number=Rand.Next(100,1000);

Console.WriteLine($"Сгенерировалось случайное число: {number}");
int digit3=number % 10;  
int digit1=number / 100; 

int res = digit1 * 10 + digit3;
Console.WriteLine(res);
