// Напишите программу на C # Sharp для вычисления суммы двух заданных целочисленных значений. 
// Если эти два значения одинаковы, вернуть тройную сумму.

// Запрашиваем информацию у пользователя
System.Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// Вводим новую перменную  и производим основное вычисление
int sum = numberA + numberB;

// Проверяем условия задачи
if (numberA == numberB) sum = 3 * sum;

// Выводим результат
System.Console.WriteLine(sum);
