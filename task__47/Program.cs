/* Задача 47. Задайте двумерный массив размером m * n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9        */

Console.Write ("Введите количество строк в массиве  ");
uint r = Convert.ToUInt32(Console.ReadLine());
Console.Write ("Введите количество столбцов в массиве  ");
uint c = Convert.ToUInt32(Console.ReadLine());
Console.Write ("Введите нижнюю границу дипазона случайных чисел  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите верхнюю границу дипазона случайных чисел   ");
int max = Convert.ToInt32(Console.ReadLine());
double [,] arr = CreateTwoDimensArray (r, c, min, max);
PrintArray(arr);

//  Функция вывода на экран элементов двуразмерного массива
void PrintArray (double [,] array)
{
    Console.WriteLine ("Элементы массива :");
    for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write ($"{array[i,j]}     ");
		}
	Console.WriteLine();
	}
}

// Функция создания  двумерного массива случайных вещественных чисел
double [,] CreateTwoDimensArray (uint row, uint col, int minValue, int maxValue)
{
  double [,] array = new double [row, col];
  for (int i = 0; i < row; i++)
  { 
    for (int j = 0; j < col; j++)
    {
	    double n = new Random().NextDouble();
        double m = n * (new Random().Next(minValue, maxValue + 1)) ;
        array[i,j] =  Math.Round(m, 1);
	}
  }
  return array;
}  
        		
     
	 
	 
	 
