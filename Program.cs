// Итоговая проверочная работа
// Программа на вход принимает массив строк.
// Из которого отбирает строки длина которых меньше или равна трём символам.
// И формирует из них новый массив.
using static System.Console;
string text1 = "Введите максимальную длину отбираемых строк: ";
string text2 = "Длина строк должна быть больше нуля";
int length = InputNaturalNumber(text1, text2);
string[] lineArray=InputStringArray("Введите через пробел элементы строкового массива: ");
string[] myArray=SelectLines(length);
WriteLine("Итоговый массив:");
WriteLine(string.Join(", ", myArray));


string[] InputStringArray(string text)
// Создание массива строк из строки консоли
{
    WriteLine(text);
    string? line = ReadLine();
    if (line == null) { line = ""; }  //чтоб не ругался
    string[] lineArray = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    return lineArray;
}

string[] SelectLines(int length)
// Отбор строк из массива не больше заданной длины
{
    string myLine="";
    for(int i=0;i<lineArray.Length;i++)
    {
        if(lineArray[i].Length<=length)
        {
            myLine=myLine+" "+lineArray[i];
        }
    }
    string[] myArray = myLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    return myArray;
}

int InputNaturalNumber(string text1, string text2)
// Ввод натурального числа
{
    int num = -1;
    while (num < 1)
    {
        num = InputInt(text1);
        if (num < 1) { WriteLine(text2); }
    }
    return num;
}

int InputInt(string text)
// Ввод целого числа
{
    bool isNumber = false; int x = 0;
    while (!isNumber)
    {
        Write(text);
        isNumber = int.TryParse(ReadLine(), out x);
        if (!isNumber) { WriteLine("Это не число"); }
    }
    return x;
}

