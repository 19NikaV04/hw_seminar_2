// Задача 2

void ChangeArray(int[,] array)
{
    for (int  i = 0; i < array.GetLength(0); i++)
    {
        for (int  j = 0; j < array.GetLength(1); j++)
        {   
            if ( i > 0 &&  i < array.GetLength(1))
           {
                int  temporary = array[i, j];
                array[i, j] = array[i, j];
                array[i, j] = temporary;
            }
            else
            {
                int  temporary = array[i, j];
                array[i, j] = array[(array.GetLength(1) - 1), j];
                array[(array.GetLength(1) - 1), j] = temporary;
            }
        }
    }
}
