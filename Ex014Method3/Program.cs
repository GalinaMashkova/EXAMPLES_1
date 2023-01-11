//Знакомство с языками программирования (лекции)
//Урок 3. Функции: продолжение

//Вид 3. Методы, которые что-то возвращают, но ничего не принимают.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3(); 
System.Console.WriteLine(year);