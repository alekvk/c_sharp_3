/* Задача 52. Задать двумерный массив из целых чисел. 
Найти среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */

// Задаем массив целых чисел
int [,] matrix = new int[,]
{
	{45, 56, 5, 9, 78, 32},
	{785, 5, 66, 93, 85, 854},
	{4, 56, 78, 85, 2, 52}
};	
	
PrintArray(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
{
	int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
	{
		sum += matrix[i,j];
	}
    double avr = (double) sum /matrix.GetLength(0);
    Console.Write($"Среднее арифметическое {j+1}-го столбца  {Math.Round(avr, 1)} ");
	Console.WriteLine();
}   

// Функция вывода на экран элементов двуразмерного массива
void PrintArray (int [,] array)
{
    Console.WriteLine ("Элементы массива : ");
    for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write ($"{array[i,j]}     ");
		}
	Console.WriteLine();
	}
    Console.WriteLine();
}   


	 
	 
	 
