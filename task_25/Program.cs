/*Задача 25: Написать цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. 3, 5 -> 243 (3?)  2, 4 -> 16  */

 long NumberToDegree (uint num, uint degr)
 {
   long prod=num;
   for (int i=1; i < degr; ++i)
   {
     prod=prod*num;
   }
   return prod;
}
  Console.Write ("Введите целое неотрицательное число  ");
  uint number=Convert.ToUInt32(Console.ReadLine());
  Console.Write ("Введите целое неотрицательное значение степени ");
  uint degree=Convert.ToUInt32(Console.ReadLine());
  Console.WriteLine ($"Число {number} в степени {degree} равно {NumberToDegree (number, degree)}");

