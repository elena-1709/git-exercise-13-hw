//Напишите программу, которая выводит третью цифру заданного
//числа или сообщает, что третьей цифры нет
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Clear();
Console.WriteLine("Введите число: ");
string? num = Console.ReadLine();

if (num.Length > 2) Console.WriteLine($"Третья цифра числа {num}: {num[2]}");

else Console.WriteLine($"Третья цифра числа {num}: Третьей цифры нет");
