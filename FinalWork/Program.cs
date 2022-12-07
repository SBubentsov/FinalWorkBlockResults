// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо
//  задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] CreateArrayRndString(int size)
{
    Random rnd = new Random();

    string[] array = new string[]
    {
            "hello", "BOOOO!", "Yes", "No", "bye", "=')", "Russia", "USA", "O_O", "Japan", "Homework", "Git", "Lol", "fun", "Dotnet", "X_X", "Canada", "UK", "FBR", "NOOB!", "?"
    };

    string[] newarray = new string[size];

    for (int i = 0; i < size; i++)
    {
        int index = rnd.Next(array.Length);
        newarray[i] = array[index];
    }

    return newarray;
}


void PrintArray(string[] arrayString)
{
    Console.Write("[");
    for (int i = 0; i < arrayString.Length; i++)
    {
        Console.Write($"\"{arrayString[i]}\"");
        if (i < arrayString.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

string[] CreaterArrayStringFilter(string[] arrayString, int filter)
{
    int size = 0;

    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= filter)
        {
            size++;

        }
    }

    string[] selArrStr = new string[size];
    int count = 0;

    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= filter)
        {
            selArrStr[count] = arrayString[i];
            count++;
        }
    }

    return selArrStr;
}


Console.Clear();

Console.WriteLine("Введите количество элементов массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите требуемое максимальное количество символов:");
int arrayfilter = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = CreateArrayRndString(arraySize);
PrintArray(arrayStrings);
Console.Write(" => ");
string[] newArrayStrings = CreaterArrayStringFilter(arrayStrings, arrayfilter);
PrintArray(newArrayStrings);