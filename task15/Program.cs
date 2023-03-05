// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите цифру:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 6 && number > 0 )
{
    Console.WriteLine("сегодня рабочий день");
}
else if (number < 8 && number > 5 )
{
    Console.WriteLine("сегодня выходной!");
}
else
{
    Console.WriteLine("не удалось определить день недели");
}