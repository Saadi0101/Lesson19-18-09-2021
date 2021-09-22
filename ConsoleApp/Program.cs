using Microsoft.Win32;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven" };
            var arr2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            ArrayHelper.Pop(ref arr2);
            ArrayHelper.Push(ref arr2, 8);
            ArrayHelper.Shift(ref arr2);
            ArrayHelper.UnShift(ref arr2, 2);
            ArrayHelper.Slice(ref arr2, 2, 7);
        }

       static class ArrayHelper
        {
            public static T Pop<T>(ref T[] arr)
            {
                Console.WriteLine("Method POP");
                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("Элементи массива: ");
                    }
                    Console.Write($"{arr[i]}, ");
                }
                Console.WriteLine();
                Console.WriteLine($"Последный элемент массива: {arr[arr.Length - 1]}");
                return arr[arr.Length - 1];
            }
            public static void Push<T>(ref T[] arr, T el)
            {
                Console.WriteLine("Method PUSH");
                Array.Resize<T>(ref arr, arr.Length + 1);
                arr[^1] = el;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("Элементи массива: ");
                    }
                    Console.Write($"{arr[i]}, ");
                }
                Console.WriteLine();
            }
            public static T Shift<T>(ref T[] arr)
            {
                Console.WriteLine("Method SHIFT");
                for (int i = 1; i < arr.Length; i++)
                {
                    if (i == 1)
                    {
                        Console.Write("Элементи массива: ");
                    }
                    Console.Write($"{arr[i]}, ");
                }
                Console.WriteLine();
                Console.WriteLine($"Первый элемент массива: {arr[0]}");
                return arr[0];
            }
            public static void UnShift<T>(ref T[] arr, T el)
            {
                Console.WriteLine("Method UNSHIFT");
                T [] arr2 = new T [arr.Length + 1];
                arr2[0] = el;
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (i+1 < arr2.Length)
                    {
                        arr2[i + 1] = arr[i];
                    }
                    else
                    {
                        Console.Write($"{arr2[i]}, ");
                        return;
                    }
                    if (i == 0) Console.Write("Элементи массива: ");
                    Console.Write($"{arr2[i]}, ");
                }
            }
            public static void Slice<T>(ref T[] arr, int bi, int ei)
            {
                Console.WriteLine();
                Console.WriteLine("Method SLICE");
                Console.Write("Элементы массива: ");
                if (bi < 0) bi = arr.Length - (bi * (-1));
                if (ei < 0) ei = arr.Length - (ei * (-1));
                for (int i = bi; i < ei; i++)
                {
                    arr[i] = arr[i];
                    Console.Write($"{arr[i]}, ");
                }
            }
       }
    }
}
