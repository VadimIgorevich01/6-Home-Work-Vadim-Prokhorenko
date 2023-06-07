﻿﻿int GetCheckedNumber (string info, string allowedCharacters)
{
    Console.WriteLine (info);
    string? numberToBeChecked = Console.ReadLine();
    while (isThereText(numberToBeChecked!, allowedCharacters!) | TestForNullOrEmpty(numberToBeChecked!))
    {
        Console.WriteLine ("Условие не выполнено или строка пуста, попробуйте ввести иначе");
        Console.WriteLine (info);
        numberToBeChecked = Console.ReadLine ();
    }
    int numberOk = Convert.ToInt32(numberToBeChecked);
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