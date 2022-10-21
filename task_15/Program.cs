//Задача 15: Программа, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.  6 -> да  7 -> да 1 -> нет

Console.WriteLine ("Введите целое число в интервале от 1 до 7  ");
int numDay=Convert.ToInt32(Console.ReadLine());
if (numDay==6||numDay == 7) 
{ 
    Console.Write("Да"); 
}   
else if (numDay>0 && numDay<6)
{
    Console.Write("Нет");
}
else 
{
    Console.WriteLine ("Число должно быть в интервале от 1 до 7");
}













