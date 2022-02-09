//Урок 4 Задание 2
//Написать программу, принимающую на вход строку — набор чисел, 
//разделенных пробелом, и возвращающую число — сумму всех чисел в строке. 
//Ввести данные с клавиатуры и вывести результат на экран.

string setNumbers = Convert.ToString(Console.ReadLine());
char[] chars = setNumbers.ToCharArray();
string summChars = "";
for (int i =0; i<chars.GetLength(0); i++)
{
    if (chars[i] !=' ')
    {
        summChars += chars[i];
    }
}
Console.WriteLine(summChars);
//int[] summNumbers = { 12, 312, 4324, 432, 42 };
//int summa = 0;
//for (int i = 0; i < summNumbers.Length; i++)
//{
//    summa = summa + summNumbers[i];
//}
////Выводим значение:
//Console.WriteLine(summa);

//Алтернативный вариант #1
////получение строки чисел с пробелами:
//string setNumbers = Convert.ToString(Console.ReadLine());
////разделяем на подстроки каждый элемент строки и делаем массив:
//string[] subs = setNumbers.Split();
////преобразуем масив строк в массив int-ов:
//int[] summNumbers = subs.Select(x => int.Parse(x)).ToArray();
////Суммируем все элементы массива:
//int summa = 0;
//for (int i = 0; i < summNumbers.Length; i++)
//{
//    summa = summa + summNumbers[i];
//}
////Выводим значение:
//Console.WriteLine(summa);

//Альтернативный варинат #2
//var sum = Console.ReadLine().Split().Select(int.Parse).Sum();
//Console.WriteLine(sum);
//Альтернативный варинат #3
//Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Sum());