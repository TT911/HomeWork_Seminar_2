// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if (number < 6)

Console.WriteLine($"{number} рабочий");

else

Console.WriteLine($"{number} выходной");