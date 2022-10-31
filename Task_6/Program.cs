// Напишите программу, которая на вход принимает число и выдает, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write(" Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number%2 == 0)
{
    Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число НЕ является чётным");
}
