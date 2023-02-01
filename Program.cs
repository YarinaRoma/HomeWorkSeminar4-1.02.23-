
/*

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Console.Clear();
double DeGree(double a,double b)
{
  double res = Math.Pow (a, b);
  return res;
}
Console.Write("Введите число :");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа :");
double b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число в степени равно " + DeGree(a,b));


*********************************************************

/*
Console.Clear();
int SumIndex( int numb)
{
    int sum = 0;
    while (numb > 0)
       sum += numb%10;
       numb = numb/10;
       
    return sum;
}
Console.Write("Введите число :");
int a = Convert.ToInt32(Console.ReadLine());
//nt result = SumIndex(a);
Console.WriteLine(SumIndex(a));


 Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]


int [] NumArray(int size)
{
    int[]array = new int[size];
    for (int i = 0;i < size;i ++)
    
    {
      
      Console.Write($"Введите элемент массива {i + 1} :");
      array[i] =Convert.ToInt32(Console.ReadLine());

    }
      
    return array;
}
void ShowArray (int[]array)
{
    for(int i = 0;i < array.Length;i++)
      Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Введите количество элементов массива :");
int size = Convert.ToInt32(Console.ReadLine());

int[]newArray = NumArray( size);
ShowArray(newArray);

*/
