﻿// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Задача 29: Напишите программу, которая генерирует массив из 8 элементов - случайных чисел (от 0 до 20) и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 3 -> [1, 2, 5, 7, 19, 6, 1, 3]

// -------------------------------

// Решение задачи 25

// Console.WriteLine("введите число A"); // запрашиваем в консоли ввода числа A, то что мы будем возводить в степень
// int a = int.Parse(Console.ReadLine()); // считываем с консоли введенное значение, меняем тип со строкового на числовой и передаем ее переменной a
// Console.WriteLine("введите число B"); // запрашиваем в консоли ввода числа B, степень
// int b = int.Parse(Console.ReadLine()); // аналогично первому числу
// Console.WriteLine(""); // пропустим строчку для красоты
// int MathPow(int x, int n) // создадим функцию MathPow, которая будет возводить число x в степень n
// {    
//     int sub = 1;
//     for (int i = 1; i <= n; i++) // повторим цикл n раз, для того чтобы перемножить число x n раз
//     {
//         sub = sub * x; // собираем наше произведение в переменную sub
//     }
//     return sub; // возвращение результата и завершение функции        
// }
// if (b > 0) // проверка на то что степень натуральное число
// {
//     int c = MathPow(a, b); // вызываем функцию MathPow и передаем полученный результат переменной c
//     Console.WriteLine($"A в степени B равно: {c}"); // выводим полученный ответ в консоль
// }
// else Console.WriteLine("Проверьте введенные числа, число B должено быть натуральным"); // если условие натуральности не выполняется, выводим к консоль соответствующее сообщение

// -------------------------------

// Решение задачи 27

// int Sum(string fstr) // задаем функцию Sum которая будет выводить сумму всех цифр строки fstr
// {
//     int s = 0; 
//     int n = fstr.Length; // длина строки
//     int[] number = new int[n]; // задаем массив number, для того чтобы предавать каждому ее элементу цыфру из строки, предварительно поменяв тип на целочисленный
//     for (int i = 0; i < n; i++) // перебираем в цикле все элементы массива и присваиваем им цифру из исходной строки
//     {       
//         number[i] = (int)(fstr[i])-48; //при преобразовнии типов с char на int, символу 0 сопоставляется числу 48, символу 1 сопоставляется 49,
//         // 2 - 50, 3 - 51, ... , 9 - 57 -> поэтому отнимаю 48, чтобы считало правильно (0 - 0, 1 - 1, 2 - 2, ... , 9 - 9)
//         s = s + number[i]; // в переменную s собираем сумму всех этих цифр
//     }
//     return s; // завершеам функцию и возвращаем значение переменной s
// }
// Console.WriteLine("Введите число"); // запрашиваем в консоли ввода числа
// string str = Console.ReadLine(); // введенное значение строкового типа присваиваем переменной str
// Console.WriteLine(""); // добавим пустой строчки для эстетики
// if (int.Parse(str)<0) // условие для отрицательных чисел
// {
//     int c = Math.Abs(int.Parse(str)); // если число отрицательное, делаем его положительным
//     str = Convert.ToString(c); // и снова конвертируем число в строку (но уже без знака минус)
// }
// int a = Sum(str); // вызываем функцию Sum с параметром str и передаем полученный результат переменной a
// Console.WriteLine($"Сумма всех цифр равна {a}"); // выводим полученный результат в консоль

// -------------------------------

// Решение задачи 29

int[] array = new int[8]; // создаем массив array из 8 элементов
array[0] = new Random().Next(0, 21); // задаем первый элемент массива случайным числом из диапозона от 0 до 20
Console.Write($"массив: [{array[0]}"); // выводим его в консоль
for (int i = 1; i < 8; i++) // перебираем в цикле оставшиеся элементы массива и выводим их также в консоль, в одну строку через запятую
{
    array[i] = new Random().Next(0, 21);
    Console.Write($", {array[i]}");
}
Console.WriteLine("]"); // закрываем квадратную скобку и переходим на другую строку