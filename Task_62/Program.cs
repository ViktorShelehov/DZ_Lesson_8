//Напишите программу, которая заполнит спирально массив 4 на 4.

///////////////////////////////////////////////////////////////
//////////////////////////- Старт -///////////////////////////
/////////////////////////////////////////////////////////////
Console.Clear();

int[,] array = new int[4, 4];
FillArraySpirally(array);

Console.WriteLine("Спирально заполненный массив:");
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

///////////////////////////////////////////////////////////////
//////////- Метод заполнения массива спирально -//////////////
/////////////////////////////////////////////////////////////

void FillArraySpirally(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    int num = 1;
    int rowStart = 0, rowEnd = n - 1;
    int colStart = 0, colEnd = m - 1;

    while (num <= n * m)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = num;
            num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = num;
            num++;
        }
        colEnd--;

        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = num;
                num++;
            }
            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = num;
                num++;
            }
            colStart++;
        }
    }
}

///////////////////////////////////////////////////////////////
////////////- Метод вывода на печать решения задачи -/////////
/////////////////////////////////////////////////////////////

void PrintArray(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

///////////////////////////////////////////////////////////////
//////////////////////////- Конец -///////////////////////////
/////////////////////////////////////////////////////////////