//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

///////////////////////////////////////////////////////////////
//////////////////////////- Старт -///////////////////////////
/////////////////////////////////////////////////////////////
Console.Clear();

int[,] matrix1 = new [,]
{
    { 5, 2, 3 },
    { 4, 7, 6 },
    { 7, 8, 4 }
};

int[,] matrix2 = new [,]
{
    { 1, 8, 7 },
    { 6, 9, 4 },
    { 3, 5, 1 }
};

PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);

int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);
Console.WriteLine();
Console.WriteLine("Результат умножения матриц:");
Console.WriteLine();
PrintMatrix(resultMatrix);
Console.WriteLine();
////////////////////////////////////////////////////////////////////////
////////////////- Метод вывода на печать заданных матриц -/////////////
//////////////////////////////////////////////////////////////////////

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

///////////////////////////////////////////////////////////////////////
//////////////////////////- Решение задачи -//////////////////////////
/////////////////////////////////////////////////////////////////////

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int cols2 = matrix2.GetLength(1);

    int[,] resultMatrix = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            int sum = 0;

            for (int k = 0; k < cols1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }

            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

///////////////////////////////////////////////////////////////////////
/////////////- Метод вывода на печать решение задачи -////////////////
/////////////////////////////////////////////////////////////////////

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//////////////////////////////////////////////////////////////////////
///////////////////////////- Конец -/////////////////////////////////
////////////////////////////////////////////////////////////////////