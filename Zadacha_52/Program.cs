Console.Clear();

Console.Write("Введите количество строк: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int N = Convert.ToInt32(Console.ReadLine());

int [,] arrayTable = new int [M, N];
Random rnd = new Random();

for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        arrayTable[i,j] = rnd.Next(20);
        
         
    }
}

for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    Console.Write("[ ");
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        Console.Write(arrayTable[i,j] + " ");
        
    }
    Console.Write("]");
    Console.WriteLine();
}

for (int j = 0; j < arrayTable.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < arrayTable.GetLength(0); i++)
    {
        avarage = (avarage + arrayTable[i, j]);
    }
    avarage = avarage / M;
    Console.Write(Math.Round(avarage, 1) + "; ");
}
Console.WriteLine();
