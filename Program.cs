﻿﻿double GetCheckedNumber (string info, string allowedCharacters)
{
    Console.WriteLine (info);
    string? numberToBeChecked = Console.ReadLine();
    while (isThereText(numberToBeChecked!, allowedCharacters!) | TestForNullOrEmpty(numberToBeChecked!))
    {
        Console.WriteLine ("Условие не выполнено или строка пуста, попробуйте ввести иначе");
        Console.WriteLine (info);
        numberToBeChecked = Console.ReadLine ();
    }
    double numberOk = Convert.ToDouble(numberToBeChecked);
    return numberOk;
}

bool TestForNullOrEmpty(string s)
{
    bool result;
    result = s == null || s == string.Empty;
    return result;
}

bool isThereText (string typedNumber, string okChars)
{
    char characterToBeChecked = ' ';
    int checkedChars = 0;
    for (int i = 0; i < typedNumber.Length; i++)
    {
        characterToBeChecked = typedNumber [i];
        for (int j = 0; j < okChars.Length; j++)
        {
            if (characterToBeChecked == okChars [j])
            {
                checkedChars++;
                break;
            }           
        }
    }
    if (checkedChars == typedNumber.Length)
    {
        return false;
    }
    else
    {
        return true;
    }
}

void ShowArray (int [] arr)
{
    Console.Write("Наш массив: [");
    if (arr.Length == 0)
    {
        Console.WriteLine ("Пустой массив, сэр]");
    }
    else
    {
        for (int w = 0; w < arr.Length; w++)
        {
            if (w != arr.Length - 1)
            {
                Console.Write(arr [w] + ", ");
            }
            else
            {
                Console.Write(arr [w] + "]");
            }
        }
    }
    Console.WriteLine();
}
//Task1_____________________________

string? digits = string.Empty;
string? typed = string.Empty;
int number = 0;
double numberDouble = 0;
string charToString = string.Empty;
int positiveCounter = 0;
string typed2 = string.Empty;
int isItDouble = 0; //0, значит, нет; 1, значит, да
do
{
    Console.WriteLine ("Введите число и нажмите enter, чтобы выйти нажмите enter ничего не вводя");
    typed = Console.ReadLine();
    if (TestForNullOrEmpty(typed!))
    {
        break;
    }
    while (isThereText(typed!, "1234567890-,"))
    {
        Console.WriteLine ("Введите число именно цифрами\nЕсли число дробное, используйте запятую(,)");
        typed = Console.ReadLine ();
    }
    typed2 = typed!;
    typed2 = typed2 + "; ";
    digits = digits + typed2;
    for (int i = 0; i < typed!.Length; i++)
    {
        if (typed [i] == ',')
        {
            isItDouble = 1;
        }
    }
    if (isItDouble == 0)
    {
        number = int.Parse(typed!);
    }
    else
    {
        numberDouble = Convert.ToDouble(typed);
    }
    if (number > 0 || numberDouble > 0)
    {
        positiveCounter++;
    }
}
while (true);
Console.WriteLine ("Следующие числа введены: " + digits + "\nКоличество чисел больше нуля: " + positiveCounter);
//_____________________________________________
//Task2________________________________________
double b1 = GetCheckedNumber ("Введите число b1", "1234567890-,");
double k1 = GetCheckedNumber ("Введите число k1", "1234567890-,");
double b2 = GetCheckedNumber ("Введите число b2", "1234567890-,");
double k2 = GetCheckedNumber ("Введите число k2", "1234567890-,");
double x = (b1 - b2) / (k2 - k1);
double y = (k1 * x + b1);
x = Math.Round(x, 1, MidpointRounding.ToZero);
y = Math.Round(y, 1, MidpointRounding.ToZero);
Console.WriteLine ($"X: {x}; Y: {y}.");