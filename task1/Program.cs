// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Write("Введите размерность m массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = int.Parse(Console.ReadLine());
double[,] randomArray = new double[m,n];


void array(int m, int n)
{
int i,j;
Random rand = new Random();
    for (i = 0; i < m; i++)
    {
    Console.WriteLine();
        for (j = 0; j < n; j++)
            {
                randomArray[i,j] = rand.NextDouble();
                Console.Write($"{randomArray[i,j]:F2} ");
            }

    }

}

array(m,n);