/* Задача 29 Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
5 -> [1, 2, 5, 7, 19]; 3 -> [6, 1, 33] */

int lengthArray = ReadInp("");
Console.Write("Массив: ");

int[] randomArray = new int[lengthArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}

// Функция ввода
int ReadInp(string Length)
{
    Console.Write("Введите длинну массива: ");
    return Convert.ToInt32(Console.ReadLine());
}

 