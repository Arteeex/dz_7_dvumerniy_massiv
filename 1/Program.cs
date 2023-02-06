Console.Clear();
System.Console.Write("Y: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("X: ");
int N = Convert.ToInt32(Console.ReadLine());
double [,] arr = new double [M,N];
Random random = new Random();


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
       arr[i,j] = random.Next(0, 100) / 10.0; 
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write("{0:F2} ", arr[i,j] + " ");
        
    }
    System.Console.WriteLine();
}
