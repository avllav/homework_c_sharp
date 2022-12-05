// See https://aka.ms/new-console-template for more information
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > b)
{
    max = a;
    Console.Write("Из двух введенных чисел максимальное первое введенное число:" + a);
}
if (a < b)
{
    max = b;
    Console.Write("Из двух введенных чисел максимальное второе введенное число:" + b);
}
else if (a == b)
{
    Console.Write("Введенные числа РАВНЫ");
}
