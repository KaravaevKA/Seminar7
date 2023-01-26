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
void FindNum (int[,] matr, int x, int y)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (x == i + 1 && y == j + 1) Console.WriteLine(matr[i,j]); 
            else Console.WriteLine("Такого числа нет");
            
        }
    }
}

Console.WriteLine("Введите количество строк массива");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строку искомой позиции");
int  x1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ряд искомой позиции");
int x2 = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = new int [lines, columns];
FillArray(Matrix);
PrintArray(Matrix);
FindNum(Matrix, x1, x2);