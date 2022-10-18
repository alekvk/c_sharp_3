
 Console.Write ("Введите целое неотрицательное число ");
 int N=Convert.ToInt32(Console.ReadLine());
 // исходя из формулировки задания, алгоритм создан для неотрицательного N 
 for (int i = 2; i <= N; i=i+2) {  
  Console.Write(i + " ");
 } 
