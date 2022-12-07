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
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        int index = rnd.Next(size);
        string entry = array[index];
        if (i < size - 1) Console.Write($"{entry}| ");
        else Console.Write($"{entry}] =>");
    }
    
    return array;
}


void PrintArray(string[] arrayString)
{
    Console.Write("[");
    for (int i = 0; i < arrayString.Length; i++)
    {
        Console.Write($"\"{arrayString[i]}\"");
        if (i < arrayString.Length - 1) Console.Write("| ");
    }
    Console.Write("]");
}

Console.Clear();

Console.WriteLine("Введите количество элементов массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());


string[] arrayStrings = CreateArrayRndString(arraySize);
// PrintArray(arrayStrings);