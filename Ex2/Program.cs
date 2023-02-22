// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Данные для ввода и вывода 
int value = InputInt("Введите число: ");
int length = numberLength(value);
resultSum(value, length);

// Ввод чисел
int InputInt(string prompt)
{
    System.Console.Write($"{prompt}");
    return Convert.ToInt32(Console.ReadLine());
}

// Подсчет цифр в числе
int numberLength(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция подсчетта суммы всех чисел в веденном значении
void resultSum(int value, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum += value % 10;
        value /= 10;
    }
    Console.WriteLine($"Сумма всех чисел в веденном значении равна {sum}.");
}

