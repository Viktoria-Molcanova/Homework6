public static class Lesson456
{
    static void Main()
    {
       //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
       //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        
      //Введение значений и чисел k и b
      
    Console.WriteLine("введите значение b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значение b2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число k2");
    double k2 = Convert.ToInt32(Console.ReadLine());

    //Расчёт пересечения двух прямых

    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;

    //Печать результатов вычисления

  Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}}
