/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2    1, -7, 567, 89, 223-> 4  */

Console.WriteLine("Введите цифры через пробел. Нажатие <Enter> означает окончание ввода");
string elements = Console.ReadLine();
int[] numArray = GetArrayFromString(elements);
Console.WriteLine($"[{String.Join(", ", numArray)}]");

int j = 0;
for (int i = 0; i < numArray.Length; ++i)
{
  if (numArray[i] > 0) ++j;
}

Console.WriteLine($"Введено {j} числа больше нуля");

// Функция создания массива из строки, содержащей цифры
int[] GetArrayFromString(string Array)
{
  string[] nums = Array.Split(' ', StringSplitOptions.RemoveEmptyEntries);
  int[] res = new int[nums.Length];
  for (int i = 0; i < nums.Length; i++)
  {
    res[i] = int.Parse(nums[i]);
  }
  return res;
}
