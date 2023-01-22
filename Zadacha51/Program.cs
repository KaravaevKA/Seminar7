void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for(int i = 0; i<matr.GetLength(0); i++)
    {
        for (int j = 0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

void MainDiagSum(int[,] matr)
{
    int sum = 0;
    for(int i = 0; i<matr.GetLength(0); i++)
    {
        for(int j = 0; j<matr.GetLength(1); j++)
        {
            if(i==j) sum = sum + matr[i,j];
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали равна {sum}");
}

int[,] matrix = new int [5,5];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
MainDiagSum(matrix);