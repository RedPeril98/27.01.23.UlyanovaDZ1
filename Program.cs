//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
int max = 0;
int min = 0;

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
max = firstNumber;
min = secondNumber;
}
else
{
max = secondNumber;
min = firstNumber;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
int max = 0;

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > max)
{
max = firstNumber;
}
if(secondNumber > max)
{
max = secondNumber;
}
if(thirdNumber > max)
{
max = thirdNumber;
}

Console.WriteLine("max = " + max);
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = number % 2;

if(remDiv == 0)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
*/


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
while(evenNumber <= number)
{
Console.Write(evenNumber + " ");
evenNumber = evenNumber + 2;
}
}
*/