// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Данные для ввода и вывода 
int valueA = InputInt("Введите число: ");
int valueB = InputInt("Введите степень: ");
degree(valueA, valueB);

// Ввод чисел
int InputInt(string prompt)
{
    System.Console.Write($"{prompt} : ");
    return Convert.ToInt32(Console.ReadLine());
}

// Подсчет степени
void degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"{b} степень числа {a} равна {result}");

}




