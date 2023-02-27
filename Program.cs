/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] GetArray(int size)
{
    string[] arrayStrings = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент: ");
        string element = Convert.ToString(Console.ReadLine());
        arrayStrings[i] = element;
    }
    return arrayStrings;
}

string[] GetArrayResult(string[] arr)
{
    string[] arr2 = new string[arr.Length];
    int len = 3;
    int pos = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= len)
        {
            arr2[pos] = arr[j];
            pos++;
        }
    }
    return arr2;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//Вводим массив с клавиатуры
Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = GetArray(size);

//Решение
string[] arrayResult = GetArrayResult(array);

//Вывод в консоль результата
PrintArray(array);
PrintArray(arrayResult);