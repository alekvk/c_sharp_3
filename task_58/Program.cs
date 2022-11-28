/*  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

// Задаем первый массив чисел
int[,] matrix1 = new int[,]
{
    {2,4},
    {3,2}
};

// Задаем второй массив чисел
int[,] matrix2 = new int[,]
{
    {3,4},
    {3,3}
};

// Задаем массив произведения матриц
int[,] matrixResult = new int[2, 2];


for (int i = 0; i < matrixResult.GetLength(0); i++)
{
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
        matrixResult[i, j] = 0;
        for (int iMatr1 = 0; iMatr1 < matrix1.GetLength(1); iMatr1++)
        {
            matrixResult[i, j] += matrix1[i, iMatr1] * matrix2[iMatr1, j];
        }
    }
}
Console.WriteLine("Первая матрица : ");
PrintArray(matrix1);
Console.WriteLine("Вторая матрица : ");
PrintArray(matrix2);
Console.WriteLine("Результирующая матрица : ");
PrintArray(matrixResult);


// Функция вывода на экран элементов двуразмерного массива
void PrintArray(int[,] array)
{
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
