//Задача 13: Программа, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Write ("Введите целое число ");
//убираем знак минус у отрицательного числа  
int number= Math.Abs(Convert.ToInt32(Console.ReadLine()));  
string numberStr=Convert.ToString(number); //преобразуем число в строку
if (numberStr.Length < 3) 
    Console.WriteLine("Третьей цифры нет");
else  
    Console.Write("Третья цифра введенного числа  " + numberStr[2]);
   
 

