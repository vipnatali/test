﻿// Написать программу, 
// которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

string[] arr1 = new string[4] {"hello", "154", "78", "Russia"};
string[] arr2 = new string[arr1.Length];
void SecondArrayWithIF(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(arr1, arr2);
PrintArray(arr2);

