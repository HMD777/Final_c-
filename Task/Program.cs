Console.WriteLine("Написать программу, которая из имеющегося массива" +
"строк формирует массив из строк, длинна которых меньше либо равна 3 символа");

void FillStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string word;
        Console.WriteLine($"Введите '{i + 1}' слово латинскими буквами: ");
        word = Console.ReadLine();
        if (word == "")
        {
            Console.WriteLine("Вы не ввели слово!");
            i = i - 1;
        }
        else array[i] = word;
    }
}

void printArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != "")
        {
            count = count + 1;
        }
    }
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] != "" & count >= 2 & j < (array.Length - 1))
        {
            Console.Write($"{array[j]}, ");
        }
        else Console.Write($"{array[j]}");
    }

}

void FilterArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < array[i].Length; j++)
        {
            count++;
        }
        if (count <= 3)
        {
            array[i] = array[i];
        }
        else array[i] = "";
    }
}

Console.WriteLine("Введите количество вводимых слов: ");
int num = int.Parse(Console.ReadLine());
string[] StringArray = new string[num];
FillStringArray(StringArray);
Console.WriteLine("Результат введенных слов: ");
printArray(StringArray);
Console.WriteLine();
FilterArray(StringArray);
Console.WriteLine("Результат фильтрации слов: ");
printArray(StringArray);