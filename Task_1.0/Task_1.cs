/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее:
a = 5; b = 7 -> max = 7 
a = 2 b = 10 -> max = 10 
a = -9 b = -3 -> max = -3*/

Console.Clear();
Console.Write ("Введите первое число:");
int Firstnomber = int.Parse(Console.ReadLine()!);
Console.Write ("введите второе число:");
int Secondnomber = int.Parse(Console.ReadLine()!);

if (Firstnomber>Secondnomber)
{
    Console.Write("Первое число " + Firstnomber + " больше чем второе " + Secondnomber);
}
else
{
    Console.Write("Второе число " + Secondnomber + " больше чем первое " + Firstnomber);
}