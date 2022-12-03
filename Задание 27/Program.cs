// Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int num = ReadInp("Введите число: ");

int length = NumLength(num);
SumNum(num, length);

// Функция подсчета цифр в числе
int NumLength(int a)
{
    int i = 0;
    while (a > 0)
    {
        a /= 10;
        i++;
    }
    return i;
}

// Функция вывода суммы цифр в числе
void SumNum(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр в числе {num} равна {sum}");
}

// Функция ввода
int ReadInp(string vvod)
{
    Console.Write(vvod);
    return Convert.ToInt32(Console.ReadLine());
}