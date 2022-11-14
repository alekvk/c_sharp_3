/* Задача 36: Задать одномерный массив, заполненный случайными числами. 
Найти сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19      [-4, -6, 89, 6] -> 0  */ 

// Функция создания массива чисел
int [] CreateArray(int sizeArray, int minValue, int maxValue)
{
  int [] array = new int [sizeArray];
   for (int index=0; index < sizeArray; ++index)
  {
    array[index] = new Random().Next(minValue, maxValue+1);
  }
  return array;
}

Console.Write("Введите количество элементов массива  ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int [] arr = CreateArray (sizeArr, -100, 100);

// Выводим элементы массива на экране 
Console.WriteLine ("Элементы массива");
Console.WriteLine($"[{String.Join(", ", arr)}]");

int sum = 0, index = 1;
while (index < sizeArr )
{
  sum += arr[index];
  index += 2;   
}
Console.WriteLine ($"Cуммa элементов, стоящих на нечётных позициях {sum}");
