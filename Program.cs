//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//
Console.WriteLine("введите 2 числа и выведите какое больше");
int a, b;
Console.WriteLine("введите первое число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("  a  ");
}
else
{
    Console.WriteLine("  b  ");
}