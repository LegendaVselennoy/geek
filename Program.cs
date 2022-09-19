// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Решение 1

Console.Write("Введите размер массива ");
int num=int.Parse(Console.ReadLine());
int[] array=new int[num];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите числа ");
    array[i]=int.Parse(Console.ReadLine());
}

void arr(int[] a) 
{
    int count=0;
   for (int i = 0; i < a.Length; i++)
   {
      if(a[i]>0)
      {
        count++;  
      }
   }
   Console.Write($"Пользователь ввёл числа больше 0 -> {count}");
}

arr(array);


/////////////////////////////////////////////////////////////

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Решение 2

Console.WriteLine("Задайте координаты ");
double b1=Convert.ToDouble(Console.ReadLine());
double b2=Convert.ToDouble(Console.ReadLine());
double k1=Convert.ToDouble(Console.ReadLine());
double k2=Convert.ToDouble(Console.ReadLine());

void IntersectionPoint(double b1,double b2,double k2,double k1){
    double x=-(b1-b2)/(k2-k1);
    Console.Write($"Пересечение точек двух прямых-> ({x};{x})");
}

IntersectionPoint(b1,b2,k2,k1);