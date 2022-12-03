// Задача 25:Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.

int numA = ReadInpA("");
int numB = ReadInpB("");
Degree(numA, numB);

void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"{a} в степени {b} = {result}");
}

// Функция ввода Числа
int ReadInpA(string A)
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

// Функция ввода Степени
int ReadInpB(string B)
{
    Console.WriteLine("Введите степень: ");
    return Convert.ToInt32(Console.ReadLine());
}

