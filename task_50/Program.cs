/* Задача 50. Написать программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

// Задаем массив целых чисел
int [,] matrix = new int[,]
{
	{45, 56, 5, 9, 78, 32},
	{785, 5, 66, 93, 85, 854},
	{4, 56, 78, 85, 2, 52}
};	
	
Console.WriteLine ("Укажите позицию элемента в массиве   ");
Console.Write ("Укажите номер строки  ");
uint numRow = Convert.ToUInt32(Console.ReadLine());
Console.Write ("Укажите номер столбца  ");
uint numCol = Convert.ToUInt32(Console.ReadLine());
PrintArray(matrix);
if (numRow < matrix.GetLength(0) && numCol < matrix.GetLength(1))
{
   Console.Write($"Искомый элемент {matrix [numRow,numCol]}");
}
else
{
   Console.WriteLine("Такого элемента в массиве нет");
} 

// Функция вывода на экран элементов двуразмерного массива
void PrintArray (int [,] array)
{
Console.WriteLine ("Элементы массива:");
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write ($"{array[i,j]}    ");
		}
	Console.WriteLine();
	}
Console.WriteLine();    
}


	 
	 
	 
