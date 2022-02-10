// Урок 4 Задание 4
//Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 
int number = 20;
Console.WriteLine(GetFibonacci(number));

static int GetFibonacci(int number)
{
    if (number == 0||number==1)
    {
        return number;
    }
    return GetFibonacci(number - 1) + GetFibonacci(number  - 2);
}
