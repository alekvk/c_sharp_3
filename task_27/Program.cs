/* Задача 27: Программа, которая принимает на вход число и выдаёт 
сумму цифр в числе.  452 -> 11   82 -> 10  9012 -> 12 */
 
  int sum=0, quotDivisNumber=1;
  Console.Write ("Введите целое неотрицательное число  ");
  int number=Convert.ToInt32(Console.ReadLine());
  for (int degree=0; quotDivisNumber > 0; ++degree)
 {
    quotDivisNumber=(int)(number/(Math.Pow(10,degree)));
     sum = sum + quotDivisNumber % 10;
 }
  
  Console.WriteLine ($"Сумма цифр в числе {number} равна {sum}");



