// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next(0, 2147483647);
Console.WriteLine($"Начальное число {number}");
int target = 0;

    if ((number >= 100) && (number < 1000)) target = number % 10;
    if ((number >= 1000) && (number < 10000)) target = (number/10) % 10;
    if ((number >= 10000) && (number < 100000)) target = (number/100) % 10;
    if ((number >= 100000) && (number < 1000000)) target = (number/1000) % 10;    
    if ((number >= 1000000) && (number < 10000000)) target = (number/10000) % 10;
    if ((number >= 10000000) && (number < 100000000)) target = (number/100000) % 10;        
    if ((number >= 100000000) && (number < 1000000000)) target = (number/1000000) % 10;
    if ((number >= 1000000000) && (number < 10000000000)) target = (number/10000000) % 10;    
    if ((number >= 10000000000) && (number <= 2147483647)) target = (number/100000000) % 10;    
 
 Console.WriteLine($"Число цель {target}");   
    
    if (number < 100)  //если делать через else, то не дают запустить "ошибки в синтаксе"

 Console.WriteLine($"Число цель отсутвует");  
