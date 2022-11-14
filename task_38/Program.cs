/* Задача 38: Задать массив вещественных чисел. 
Найти разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76  */

// Функция создания массива случайных чисел
double [] CreateArray(int sizeArray, int minValue, int maxValue)
{
  double [] array = new double [sizeArray];
   for (int index=0; index < sizeArray; ++index)
   {
     double n = new Random().NextDouble();
     double m = n * (new Random().Next(minValue, maxValue + 1)) ;
     array[index] =  Math.Round(m, 2);
   }
  return array;
}

Console.Write("Введите количество элементов массива  ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
double [] arr = CreateArray (sizeArr, -100, 100);

// Выводим элементы массива на экран 
Console.WriteLine ("Элементы массива");
Console.WriteLine($"[{String.Join("  ", arr)}]");

double min = arr[0], max =arr[0];
for (int i = 1; i < sizeArr; ++i)
{
  if (min > arr[i])
  {
    min = arr [i];
  }
  if (max < arr[i])
  {
   max = arr [i];
  }
}

Console.WriteLine ($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива равна {max-min}");
