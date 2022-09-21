//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100,1000);
Console.WriteLine($"Начальное число {number}");
int num1 = number / 10;
int num2 = number % 100; //записывает целое число, которое было после запятой... 
int target = (num2 / 10);
Console.WriteLine($"Число цель {target}");
