
/*    Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] matrix = CreateThreeDimensArray(2, 2, 2, 10, 99);
PrintArray(matrix);

// Функция вывода на экран элементов трехразмерного массива
void PrintArray(int[,,] array)
{
    Console.WriteLine("Элементы массива : ");
    for (int l = 0; l < array.GetLength(2); l++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, l]} ({i}, {j}, {l})  ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

// Функция создания  трехмерного массива случайных чисел
int[,,] CreateThreeDimensArray(uint row, uint col, uint line, int minValue, int maxValue)
{
    int[,,] array = new int[row, col, line];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int l = 0; l < line; l++)
            {
                array[i, j, l] = new Random().Next(minValue, maxValue + 1);
            }
        }

    }
    return array;
}

