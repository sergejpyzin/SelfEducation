// Запрашиваем данные у пользователя
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Проверяем условия задачи и выводим решение
if (number >= 5 && number <= 10)
{
    System.Console.WriteLine("Число " + number + " находится в интервале от 5 до 10");
}
else
{
    System.Console.Write("Число " + number + " неивестно. Попробуйте еще раз");
}


