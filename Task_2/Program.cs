//Написать программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.Clear();
Console.Write(" Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write(" Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA >= numberB)
{
    Console.WriteLine("Первое число большее, второе меньшее");
}
else
{
    Console.WriteLine("Второе число большее, первое меньшее");
}







