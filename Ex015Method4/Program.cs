//Знакомство с языками программирования (лекции)
//Урок 3. Функции: продолжение

//Вид 4. Методы, которые что-то принимают, и что-то возвращают.

// 1. Вариант.
// string Method4(int count, string text)
// {
//     int i = 0;
//      string result = String.Empty; //изначально выходит пустой строкой

//      while (i < count)
//      {
//          result = result + text;
//          i++;
//      }
//      return result;
//  }
// String res = Method4(10, "z");
// Console.WriteLine(res);

// 2. Вариант/
string Method4(int count, string text)
{
    string result = String.Empty; 
    for (int i = 0; i < count; i++) //  инициализация счетчика-проверка условия-делается инкримент (увеличение счетчика)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);