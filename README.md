# Итоговая контрольная работа по основному блоку

## Постановка задачи
Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

### Ход решения
Для решения поставленной задачи создан проект в .NET  с именем kontrRabota1
*Словесное описание алгоритма*
В программе kontrRabota1.cs создан метод isLessThanThreeSymbol(string inputString)
типа bool, входным параметром которого является строка, а выходным - значение true или false.
True - если во во входной строке не более трех символов, false - если более.
В основном методе Main организован ввод с консоли массива строк, формирование нового
массива, состоящего из элементов не более трех символов путем цикла по введенному массиву и поэлементного
вызова метода isLessThanThreeSymbol, и вывода на консоль нового массива.
Если ни один из элементов введенного массива не удовлетворяет поставленному в задаче условию,
то на консоль выводится пустой массив - [ ].

Также составлена блок-схема алгоритма 
![Блок-схема](https://i.postimg.cc/C5vDzbtv/image.png)