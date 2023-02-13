// Напишите программу на C # Sharp для проверки двух заданных целых чисел и 
// верните true, если одному из них будет 30 или если их сумма равна 30.

// Запрашиваем информацию у пользователя
System.Console.Write("Введите превое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// Проводим вычисления
int result = numberA + numberB;

// Проверяем условия и выводим результат
if (numberA == 30 || numberB == 30 || result == 30)
{
    System.Console.WriteLine(true);
}
else
{
    System.Console.WriteLine(false);
}