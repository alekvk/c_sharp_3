//Задача 10 Программа, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5     782 -> 8   918 -> 1

Console.Write ("Введите целое трехзначное число ");
int number=Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{ 
    Console.Write("Необходимо ввести трехзначное число");
}
else 
{
    int hundreds= number/100; //целочисленное деление для выделения числа разяда сотен
    int tens=(number-hundreds*100)/10;//целочисленное деление для выделения числа разяда десятков
    Console.Write(tens);   
}

 