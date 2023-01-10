/* Задача: Написать программу, которая из имеющегося массива строк формирует массив
из строк, длина которых меньше либо равна 3 символа. Первоначальный массив
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

// Методы

void ArrayConversion(string[] arrayInput, string[] arrayOutput)
{
    int count = 0;
    for (int i = 0; i < arrayInput.Length; i++)
    {
        if (arrayInput[i].Length <= 3)
        {
            arrayOutput[count] = arrayInput[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

// Решение

string[] arrayInput = new string[4] { "hello", "2", "world", ":-)" };
string[] arrayOutput = new string[arrayInput.Length];
ArrayConversion(arrayInput, arrayOutput);
PrintArray(arrayOutput);