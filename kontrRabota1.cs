// Итоговая контрольная работа по основному блоку
// Задача. Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

using System;

namespace kontrRabota1
{
    class kontrRabota1
    {
        // метод проверки строки на условие длины не более трех символов
        static bool isLessThanThreeSymbol(string inputString)
        {
            bool outIsLessThanThreeSymbols = false;
            if (inputString.Length <= 3) outIsLessThanThreeSymbols = true;
            return outIsLessThanThreeSymbols;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное количество элементов массива строк ");
            int amountString = int.Parse(Console.ReadLine());
            if (amountString <= 0)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            string[] stringArray = new string[amountString]; // объявление входного массива
            string[] newStringArray = new string[amountString]; // объявление нового массива
            int amountStringsNewArray = 0; // объявление счетчика элементов нового массива

            // цикл ввода массива строк
            for (int i = 0; i < amountString; i++)
            {
                Console.Write("Введите " + i + "-й элемент массива, тип - строка ");
                stringArray[i] = Console.ReadLine();
            }
            // конец цикла ввода массива строк

            // цикл вывода на консоль введенного массива
            Console.Write("\nВведенный массив строк:\n[ ");
            for (int i = 0; i < amountString; i++)
            {
                Console.Write(stringArray[i] + " ");
            }
            // конец цикла вывода на консоль введенного массива
            Console.Write(" ]\n");

            // цикл проверки элементов введенного массива и формирования нового
            for (int i = 0; i < amountString; i++)
            {
                bool flagLessThanThreeSymbols = false;
                flagLessThanThreeSymbols = isLessThanThreeSymbol(stringArray[i]);
                if (flagLessThanThreeSymbols)
                {
                    newStringArray[amountStringsNewArray] = stringArray[i];
                    amountStringsNewArray++;
                } 
            }
            // конец цикла проверки элементов введенного и массива и формирования нового
            amountStringsNewArray = (amountStringsNewArray == 0) ? amountStringsNewArray : amountStringsNewArray--; // уменьшение на единицу количества элементов нового массива

            // цикл вывода на консоль нового массива
            Console.Write("\nМассив с элементами, длины которых меньше, либо равны трем символам:\n[ ");
            for (int i = 0; i < amountStringsNewArray; i++)
            {
                Console.Write(newStringArray[i] + " ");
            }
            // конец цикла вывода на консоль нового массива
            Console.Write(" ]\n\n");
        }
    }
}
