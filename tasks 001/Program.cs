// Задача 1

double[,] ranArray = new double[m,n];
Random rand = new Random();

void mas(int m, int n)
{
     for (i = 0; i < m.GetLength; i++)
    {
        for (j = 0; j < n.GetLength; j++)
       {
           ranArray[i,j] = rand.NextDouble() * 1000;
          Console.Write($«{ranArray[i,j]}»);
       }
      Console.WriteLine();
    }
}

if (m2<1 || n2<1)
{
    Console.Write($«\n Позиции строк не могут быть отрицательными»);
}
else 
{
    if (m2 <= m+1 &&  n2 <= n+1)
   Console.WriteLine($«\n Значение элемента равно: {ranArray[m2-1,n2-1]}»);
}
Console.WriteLine($«\n Такого элемента нет в массиве»);
