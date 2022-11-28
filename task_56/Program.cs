/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

// Задаем массив целых чисел
int[,] matrix = new int[,]
{
    {8, 6, 3, 5},
    {7, 5, 1, 9},
    {4, 4, 9, 9},
    {5, 7, 1, 8}
};

// Задаем переменную minSum и инициализируем ее значением  с помощью функции суммирования строк массива
int minSum = sumRowArray(matrix, 0);
int indexMinSum = 0;

for (int i = 1; i < matrix.GetLength(0); i++)
{
    if (minSum > sumRowArray(matrix, i))
    {
        minSum = sumRowArray(matrix, i);
        indexMinSum = i;
    }
}

PrintArray(matrix);
Console.WriteLine($"Наименьшая сумма элементов в {indexMinSum + 1}-й строке массива ");

//Функция суммирования строк массива
int sumRowArray(int[,] array, int indexRow)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[indexRow, j];
    }
    return sum;
}

// Функция вывода на экран элементов двуразмерного массива
void PrintArray(int[,] array)
{
    Console.WriteLine("Элементы массива : ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}     ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}