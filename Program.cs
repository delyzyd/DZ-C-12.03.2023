﻿// Семинар 9. 
// Рекурсия, решение всех задачь спомощью метода рекурсия
// Рекурсия - это функция которая вызывает сама себя.
// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int n = InputInt("Введите положительное число");
// int m = 1;
// if (n < 1)
// {
//     System.Console.WriteLine("Вы ввели не положительное число");
// }
// System.Console.WriteLine(NaturalNumber(n, m)); // если перенести данную строку на строку 19 то измениться порядок набора чисел

// int NaturalNumber(int n, int m)
// {
//     if (n == m)
//         return n;
//     else
//         System.Console.WriteLine($"{NaturalNumber(n, m + 1)}, ");
//     return m;
// }

// int InputInt(string output)
// {
//     System.Console.WriteLine(output);
//     return int.Parse(Console.ReadLine());
// }

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// int m = InputInt("Введите M:");
// int n = InputInt("Введите N:");
// System.Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

// int InputInt(string output)
// {
//     System.Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// int CountNaturalSum(int m, int n)
// {
//     if (m == n)
//         return n;
//     return n + CountNaturalSum(m, n - 1);
// }
// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// System.Console.WriteLine("Введите два положительных числа: M и N.");
// int m = InputInt("Введите M: ");
// int n = InputInt("Введите N: ");
// System.Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

// int InputInt(string output)
// {
//     System.Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (m > 0 && n == 0)
//         return Akkerman(m - 1, 1);
//     else
//         return Akkerman(m - 1, Akkerman(m, n - 1));
// }
// Как классно когда задачи прорешиваются на семинаре.