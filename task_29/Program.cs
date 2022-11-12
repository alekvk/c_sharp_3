/*Задача 29: Программа, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  6, 1, 33 -> [6, 1, 33] */

void FillArray (int [] collection)
{
    int numberElementsCollection = collection.Length;
    for (int i = 0; i< numberElementsCollection; ++i)
    {
       Console.Write ($"Введите значение {i+1}-го  элемента массива "); 
       collection[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}

void PrintArray (int [] array )
{

  int LengthArray=array.Length;
  for (int i = 0; i < LengthArray ; ++i)
  {
       Console.WriteLine ($"Значение элемента массива с индексом {i} равно {array[i]}"); 
  }
}

Console.WriteLine ("Введите количество элементов массива  ");
//int numberElementsArray = Convert.ToInt32(Console.ReadLine());
int [] array = new int [Convert.ToInt32(Console.ReadLine())];

FillArray (array) ;
PrintArray (array); 














