//Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного
//массива.

///////////////////////////////////////////////////////////////
//////////////////////////- Старт -///////////////////////////
/////////////////////////////////////////////////////////////
Console.Clear();

var rows = GetNonnegativeUserNumber("Введите количество строк массива: ", "Input error!");
var columns = GetNonnegativeUserNumber("Введите количество столбцов массива: ", "Input error!");
var min = GetUserNumber("Введите минимальное значение массива: ", "Input error!");
var max = GetUserNumber("Введите максимальное значение массива: ", "Input error!");

var arr = GenerateArray(rows, columns, min, max);

PrintArray(arr);

SortRowsDescending(arr);

Console.WriteLine("Массив после сортировки по убыванию:");
PrintArray(arr);

/////////////////////////////////////////////////////////////////
////////////////- Генерация массива -////////////////////////////
///////////////////////////////////////////////////////////////

int[,] GenerateArray(int m, int n, int minValue, int maxValue)
{
    int [,] arr = new int [m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

////////////////////////////////////////////////////////////////
//////////////////////- Ввод данных -//////////////////////////
//////////////////////////////////////////////////////////////

int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}

////////////////////////////////////////////////////////////////

int GetNonnegativeUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput) && userInput >= 0)
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}

///////////////////////////////////////////////////////////////////
/////////////////////- Вывод на печать -//////////////////////////
/////////////////////////////////////////////////////////////////

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{i}:   ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

///////////////////////////////////////////////////////////////////
////////////////////- Решение задачи -////////////////////////////
/////////////////////////////////////////////////////////////////

void SortRowsDescending(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        int[] tempArray = new int[cols];
        for (int j = 0; j < cols; j++)
        {
            tempArray[j] = array[i, j];
        }
        Array.Sort(tempArray);
        Array.Reverse(tempArray);
    
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = tempArray[j];
        }
    }
}

//////////////////////////////////////////////////////////////////
////////////////////- Конец -////////////////////////////////////
////////////////////////////////////////////////////////////////