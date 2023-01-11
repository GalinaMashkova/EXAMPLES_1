//Знакомство с языками программирования (лекции)
//Урок 3. Функции: продолжение

//Вид 2. Методы, которые ничего не возвращают, но могут принимать какие то аргументы.

//1 вариант
//void Method2(string msg)
//{
//    Console.WriteLine(msg);
//}
//Method2(msg:"Текст сообщения");

//2 вариант
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "Новый Текст");