/* Задача 34: Задать массив заполненный случайными положительными 
трёхзначными числами. Написать программу, которая покажет 
количество чётных чисел в массиве. [345, 897, 568, 234] -> 2  */

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
int [] arr = CreateArray (sizeArr, 100, 999);

// Выводим элементы массива на экране 
Console.WriteLine ("Элементы массива");
Console.WriteLine($"[{String.Join(", ", arr)}]");

// Задаем счетчик количества четных чисел
int j=0;
for (int index = 0; index < sizeArr; ++index)
{
  if (arr[index]%2==0) 
  {
    ++j;
  }
}
Console.WriteLine ($"Количество четных чисел в массиве {j}");

