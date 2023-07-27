// Итоговая контрольная работа по основному блоку
// Задача. Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выпаолнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

using System;

namespace kontrRabota1
{
    class kontrRabota1
    {
        static bool isLessThanThreeSymbol(string inputString)
        {
            bool outIsLessThanThreeSymbols = false;
            return outIsLessThanThreeSymbols;
        }
        static void Main(string[] args)
        {
            /*Console.Write("Введите целое положительное количество элементов массива строк  = ");
            int amountString = int.Parse(Console.ReadLine());
            if (amountString <= 0)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }*/
            /*Console.Write("Введите элемент массива, тип - строка ");
            string array1 = Console.ReadLine();
            Console.WriteLine("Введенная строка: " + array1);*/
            Console.Write("Введите количество элементов массива строк ");
            int amountString = int.Parse(Console.ReadLine());
            string[] stringArray = new string[amountString];
            Console.Write("Введите элемент массива, тип - строка ");
            stringArray[0] = Console.ReadLine();
            Console.WriteLine("Введенная строка: " + stringArray[0]);
        }
    }
}
