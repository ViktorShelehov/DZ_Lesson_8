﻿//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

///////////////////////////////////////////////////////////////
//////////////////////////- Старт -///////////////////////////
/////////////////////////////////////////////////////////////
Console.Clear();

int[,,] array = GenerateArray();

Console.WriteLine("Трехмерный массив:");

PrintArrayWithIndices(array);

/////////////////////////////////////////////////////////////////
////////////- Метод формирования трехмерного массива -//////////
///////////////////////////////////////////////////////////////

int[,,] GenerateArray()
{
    int[,,] array = new int[2, 5, 3];
    int number = 10;

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                array[i, j, k] = number;
                number++;
            }
        }
    }
    return array;
}

/////////////////////////////////////////////////////////////////
////////////- Метод вывода на печать решения задачи -///////////
///////////////////////////////////////////////////////////////

void PrintArrayWithIndices(int[,,] array)
{
    int dim1 = array.GetLength(0);
    int dim2 = array.GetLength(1);
    int dim3 = array.GetLength(2);

    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                Console.WriteLine($"Индексы: {i}, {j}, {k} Значение: {array[i, j, k]}");
            }
        }
    }
}

////////////////////////////////////////////////////////////////
//////////////////////////- Конец -////////////////////////////
//////////////////////////////////////////////////////////////