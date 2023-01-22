//Вывод на экран матрицы со случайными вещественными числами
void PrintArray(double[,] matr)
{
    for (var i = 0; i < matr.GetLength(0); i++)
    {
        for (var j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for(var i = 0; i<matr.GetLength(0); i++)
    {
        for (var j = 0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().NextDouble() * new Random().Next(-9,10);
        }
    }
}

double[,] matrix = new double [3,4];
FillArray(matrix);
PrintArray(matrix);