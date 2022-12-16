public static class Lesson456
{
    static void Main()
    {
       //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

      //Определение количества вводимых чисел

      Console.Write("Введите количество чисел ");
      int A = int.Parse(Console.ReadLine());
      int count = 0;
      for (int i = 0; i < A; i++)
    {
      //Введение чисел пользователем
      Console.Write($"Введите число {i + 1}: ");
      int B = int.Parse(Console.ReadLine());

      //Вычисление количества положительных чисел

      if (B > 0)
        count++;
      Console.WriteLine($"Положительных чисел: {count}");
}}  }
