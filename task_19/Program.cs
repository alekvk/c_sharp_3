// Задача 19
// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет    12821 -> да   23432 -> да
Console.Write ("Введите целое число ");  
int number=Convert.ToInt32(Console.ReadLine());
// Вычисляем кол-во цифр в числе
int numDigits= Convert.ToInt32(Math.Floor(Math.Log10(( Math.Abs(number)))))+1;
// Определяем степени числа десять для вычисления первой (левой) цифры числа и последней (правой) цифры
int degreeLeft=numDigits-1, degreeRight=0; 
// Определяем кол-во итераций в цикле  n (половина введенного числа)
int i=0, n=numDigits/2;
while (i<n)
{
if (Math.Floor((number/(Math.Pow(10,degreeLeft)))%10)
 == Math.Floor((number/(Math.Pow(10,degreeRight)))%10)) 
{
   degreeLeft=degreeLeft-1;
   degreeRight=degreeRight+1;
   i=i+1;
}
else
{
   break;
}
}
if (i==n)
    Console.Write ("Введенное число - палиндром");   
else
    Console.Write ("Введенное число - не палиндром");    
 
 
   
  