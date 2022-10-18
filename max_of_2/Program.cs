//Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7

Console.Write("Введите первое число  ");
double num_1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число  ");
double num_2=Convert.ToDouble(Console.ReadLine());
if (num_1 > num_2) {
Console.WriteLine("");    
Console.WriteLine("max = " + num_1);   
} else {
if (num_1 < num_2) {
Console.WriteLine("");    
Console.WriteLine("max = " + num_2);   
}
}


