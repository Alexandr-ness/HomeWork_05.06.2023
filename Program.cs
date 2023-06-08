// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



// Console.Write("Введите начало: ");
// int start = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите конец: ");
// int end = Convert.ToInt32(Console.ReadLine());

// string Rec(int end, int start)
// {
//     if (end == start)
//     {
//         return end.ToString();
//     }
//     return (end + Rec(end - 1, start ));
// }
// Console.WriteLine(Rec(end, start));




///////////////////////////////////////////////////////////////////////////////////////////////////


// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Rec (int m, int n)
// {
//     if (m == n)
//     {
//          return n;
//     }
//     else
//     {
//          return m + Rec(m + 1, n);
//     }
// }
// Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {Rec(m,n)}");





///////////////////////////////////////////////////////////////////////////////////////////////

// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



// Console.Write("Введите M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Rec (int m, int n)
// {
//     if (m == 0)
//     return n+1;
//     else
//         if (n == 0)
//         return Rec (m -1, 1);
//     else
//         return Rec(m -1, Rec(m, n - 1));
// }
// Console.Write($"Функция Аккермана {Rec(m,n)}");
