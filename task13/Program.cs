// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;
for (int i=1; (number/i) >= 100; i=i*10)
{
    result = (int)number/(int)i;
}
result = result % 10;
if(result>=1)
{
    Console.WriteLine("третья цифра:" + result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}


