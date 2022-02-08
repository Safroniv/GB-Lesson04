//Урок 4 Задание 2
//Написать программу, принимающую на вход строку — набор чисел, 
//разделенных пробелом, и возвращающую число — сумму всех чисел в строке. 
//Ввести данные с клавиатуры и вывести результат на экран.

//получение строки чисел с пробелами:
string setNumbers = Convert.ToString(Console.ReadLine());
//разделяем на подстроки каждый элемент строки и делаем массив:
string[] subs = setNumbers.Split();
//преобразуем масив строк в массив int-ов:
int[] summNumbers = subs.Select(x => int.Parse(x)).ToArray();

//Суммируем все элементы массива:
int summa = 0;
for (int i = 0; i < summNumbers.Length; i++)
{
    summa = summa + summNumbers[i];
}
//Выводим значение:
Console.WriteLine(summa);