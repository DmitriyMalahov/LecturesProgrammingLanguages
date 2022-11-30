// Вид 1 - Ничего не принимает и ничего не возвращает.

void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();


// Вид 2 - Ничего не возвращают, но могут принимать какие-то аргументы.

void Method2(string msg)
{
        Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения"); // Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
// Method21("Текст", 4);  
// Method21(count: 4, msg: "Новый Текст");

// 3 Вид. Ничего не принимают, но что то возвращают.

int Metohod3()
{
    return DateTime.Now.Year;
}

int year = Metohod3();
// Console.WriteLine(year);

// 4 Вид. Который и принимаю и возврвщвют что то.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //  string result = "";

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z ");
Console.WriteLine(res);