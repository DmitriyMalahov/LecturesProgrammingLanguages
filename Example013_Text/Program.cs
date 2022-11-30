// Дан текст. 
// В тесте нужно 
// 1. все пробелы заменить черточками,
// 2. маленькие буквы "к" заменить большими "К", 
// 3. а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взчли приступом согласие присского короля. "
            + "Вы так красноречивыю Вы дадите мне чаю?";

// string s = "qwerty";
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();