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
            matr[i,j] = i+j;
        }
    }
}
void FindNum (int[,] matr, int X)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (X==i*j) 
            {
                Console.WriteLine(matr[i,j]);
                break;
            }
            else 
            {
            Console.WriteLine("Такого числа в массиве нет");
            }
        }
        
    }
}

Console.WriteLine("Введите количество строк массива");
int Lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int Columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомую позицию");
int Pos = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = new int [Lines, Columns];
FillArray(Matrix);
PrintArray(Matrix);
FindNum(Matrix, Pos);