/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

// Задаем массив целых чисел
int[,] matrix = new int[,]
{
    {5, 6, 3, 8},
    {7, 5, 1, 9},
    {4, 4, 8, 3}
};

// Выводим на экран элементы массива до сортировки	
PrintArray(matrix);

// Упорядочиваем элементы строк массива
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        int maxPosition = j;
        for (int q = j + 1; q < matrix.GetLength(1); q++)
        {
            if (matrix[i, q] > matrix[i, maxPosition])
            {
                maxPosition = q;
                int temporary = matrix[i, j];
                matrix[i, j] = matrix[i, maxPosition];
                matrix[i, maxPosition] = temporary;
            }

        }

    }
}

Console.WriteLine("Элементы массива после сортировки");
// Выводим на экран элементы массива после сортировки	
PrintArray(matrix);


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