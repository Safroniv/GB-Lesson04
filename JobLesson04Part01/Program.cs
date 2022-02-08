// Урок 4 Задание 1
//Написать метод GetFullName(string firstName, string lastName, string patronymic), 
//принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
//Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

//получение исходных данных для метода:
{
    Console.WriteLine(GetFullName("Иван", "Иванов", "Иванович"));
    Console.WriteLine(GetFullName("Пётр", "Петров", "Петрович"));
    Console.WriteLine(GetFullName("Сидор", "Сидоров", "Сидорович"));
    Console.WriteLine(GetFullName("Сергей", "Сергеев", "Сергеевич"));
}
//Возвращение объёдинённой строки с ФИО:
string GetFullName(string firstName, string lastName, string patronymic)
{
    string FCs = lastName + " " + firstName + " " + patronymic;
    return FCs;
}