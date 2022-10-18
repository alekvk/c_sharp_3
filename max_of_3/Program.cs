//Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7   44 5 78 -> 78   22 3 9 -> 22

      // По заданию на вход принимаются 3 числа. Объявляем и инициализируем счетчик запросов N
      int N=3;
      Console.Write("Введите число ");
      int max=Convert.ToInt32(Console.ReadLine());
      for (int i=1; i < N; ++i) { 
      Console.Write("Введите число ");
      int num = Convert.ToInt32(Console.ReadLine());
        if (num > max) {
        max=num;   
        }
      }
    Console.WriteLine("");
    Console.WriteLine("Максимальное число -  " + max);
 