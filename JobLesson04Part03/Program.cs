//Урок 4 Задание 3
//Написать метод по определению времени года. 
//На вход подаётся число – порядковый номер месяца. 
//На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
//Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
//Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
//Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

Console.WriteLine("Здравствуйте, подскажите номер текущего месяца?");
int numMonth = Int32.Parse(Console.ReadLine());

if (numMonth > 0 && numMonth < 13)
{
    SeasonsYear seasons = SeasonIndentification(numMonth);
    string seasonOfYear = NameMonth(seasons);
    Console.WriteLine(seasonOfYear);
}
else
{
    Console.WriteLine("Ошибка: введите число от 1 до 12");
}

static SeasonsYear SeasonIndentification(int numMonth)
{

    switch (numMonth)
    {
        case 3:
        case 4:
        case 5:
            return SeasonsYear.Spring;
        case 6:
        case 7:
        case 8:
            return SeasonsYear.Summer;
        case 9:
        case 10:
        case 11:
            return SeasonsYear.Autumn;
            break;
        default:
            return SeasonsYear.Winter;
    }
    
}
   static string NameMonth(SeasonsYear seasons)
{
    switch (seasons)
    {
        case SeasonsYear.Winter:
            {
                return "Зима";
            }
        case SeasonsYear.Spring:
            {
                return "Весна";
            }
        case SeasonsYear.Summer:
            {
                return "Лето";
            }
        case SeasonsYear.Autumn:
            {
                return "Лето";
            }
        default:
            return "Ошибка: введите число от 1 до 12";
    }
}
enum SeasonsYear
{
    Winter = 1,
    Spring,
    Summer,
    Autumn
}