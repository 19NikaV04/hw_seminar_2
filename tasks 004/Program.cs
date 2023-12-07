// Задача 4

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i = tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j = tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i = matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j = matrixForPrint.GetLength(1); j++)
        {
            Console.Write(matrixForPrint[i,j] + "\t")
        }

        Console.WriteLine();
    }
}

int[] MinNamberIndex(int[,] matrix)
{
    int[] MinNamberPos = new int[2];

    for (int i = 0; i = matrix.GetLength(0); i++)
    {
        for (int j = 0; j = matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < matrix[MinNamberPos[0], MinNamberPos[1]])
            {
                MinNamberPos[0] = i;
                MinNamberPos[1] = j;
            }
        }
    }

    return MinNamberPos;
}

int[,] RowAndCol(int[,] oldMatrix, int[] indexes)
{
    var newMatrix = new int[oldMatrix.GetLength(0) - 1, oldMatrix.GetLength(1) - 1];

    for (int i = 0; x = 0; i = oldMatrix.GetLength(0); i++)
    {
        if (i == indexes[0])
        continue;

        for (int j = 0; y = 0; j = oldMatrix.GetLength(1); j++)
        {
            if (j == indexes[1])
            continue;

            newMatrix[x,y] = oldMatrix[i,j];
            y++;
        }

        x++;
    }

    return newMatrix;
}

// ----------------------------------------------------------------

int rows = ReadInt("Введите количество строк в матрице: ");

int cols = ReadInt("Введите количество столбцов в матрице: ");

var matrix = GenerateMatrix(rows, cols, 1, 10);

PrintMatrix(matrix);
Console.WriteLine();

var MinNamberPos = MinNamberIndex(matrix);

Console.WriteLine(string.Join(" ", MinNamberPos));
Console.WriteLine();
PrintMatrix(RowAndCol(matrix, MinNamberPos));
