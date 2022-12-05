//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Необходимо ввести три числа");
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
//-----------------
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
//-----------------
Console.Write("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());
//Определяем максимальное число из введенных
double max=a;
if ((a > b) && (a > c))
{
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Из введенных чисел максимальное первое число: " + max);
}
else if ((b > a) && (b > c))
{
    max=b;
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Из введенных чисел максимальное второе число: " + b);
}
else if ((c > b) && (c > a))
{
    max=c;
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Из введенных чисел максимальное третье число: " + c);
}
else
{
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Введенные числа РАВНЫ: первое число:" + a + "; второе число:"+b+"; третье число: "+c);
}