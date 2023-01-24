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
            matr[i,j] = new Random().Next(1, 100);
        }
    }
}
void AverageSum (int[,] matr)
{
   
   double SumAvg = 0;
   for (int j = 0; j < matr.GetLength(1); j++)
   {
    double sum = 0;
    for (int i= 0; i < matr.GetLength(0); i++)
    {
        sum += matr[i,j];
    }
    SumAvg = sum / matr.GetLength(1);
    Console.WriteLine($"Среднее значение {j+1} столбца равно: {SumAvg}");
   }
}

Console.WriteLine("Введите количество столбцов");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество рядов");
int row = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row,col];

FillArray(array);
PrintArray(array);
AverageSum(array);