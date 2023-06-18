// __________________________Задача 41__________________ 
// Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.Write("Введите количество чисел в массиве = ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];

// void EnteringNumbers(int[] numbers)
// {
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write("Введите число = ");
//         numbers[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }
// void PositiveNumbers(int[] numbers)
// {
//     int result = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//     if (numbers[i]>0)
//     {
//         result = result + 1;

//     }
//     else if (numbers[i]<=0)
//     {
        
//     }
   
//     }
//     Console.WriteLine($"Количество положительных чисел = {result}");
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("Массив:[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// EnteringNumbers(numbers);
// PrintArray(numbers);
// PositiveNumbers(numbers);


// ____________________Задача 43:______________________________
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите число b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Отрезок A = [ {b1} | {k1} ]");
Console.WriteLine($"Отрезок B = [ {b2} | {k2} ]");

    if(k1!=k2)
    {
        double x = -(b1-b2)/(k1-k2);
        double y = k1*x+b1;
        Console.WriteLine($"Пересечение в точке x;y ({x};{y})"); 
    }
    else if (k1==k2)
    {
        Console.WriteLine($"Прямые параллельны");
    }