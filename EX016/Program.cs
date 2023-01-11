//Задача. Вывести таблицу умножения на экран.
for (int i = 2; i < 10; i++) // внешний счетчик
{
    for (int j = 2; j <= 10; j++) // внутренний счетчик
    {
       Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}