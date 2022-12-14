//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int evennum;
/* тож же самый алгоритм при использовании if-else
if ((num == 1) || (num == 0))
{
    Console.Write("Четные числа не найдены");
}
else
{
    Console.Write("Четные числа в диапазоне от 1 до " + num + ": ");
    while (count <= num)
    {
        if (count % 2 == 0)
        {
            evennum = count;
            Console.Write(evennum + ", ");
        }
    count++;
    }
}
*/
switch (num) //используем switch 
{
    case 1:
    case 0:
        Console.Write("Четные числа не найдены");
        break;
    default:
        Console.Write("Четные числа в диапазоне от 1 до " + num + ": ");
        while (count <= num)
        {
            if (count % 2 == 0)
            {
                evennum = count;
                Console.Write(evennum + ", ");
            }
            count++;
        }
        break;
}