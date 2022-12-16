// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


Console.WriteLine("Введите натуральные числа M и N для нахождения суммы элементов от M до N");
Console.Write("Введите M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int SumOfElems(int num1, int num2)
{
    if (num1 == num2) return num1;
    return num1 + SumOfElems(num1 + 1, num2);
}


if (number1 >= 0 && number2 >= 0)
{
    if (number1 <= number2)
    {
        int result = SumOfElems(number1, number2);
        Console.WriteLine(result);
    }
    else if (number1 > number2)
    {
        int result = SumOfElems(number2, number1);
        Console.WriteLine(result);
    }
}
else Console.WriteLine("Ошибка! Введите натуральные числа");