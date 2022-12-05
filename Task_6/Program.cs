//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
//int rem = num % 2;
if (num % 2 == 0)
{
    Console.WriteLine("Введенное число " + num + " является четным");
}
else 
{
    Console.WriteLine("Введенное число " + num + " является нечетным");
} 
