// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.Write("Введите размерность m массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = int.Parse(Console.ReadLine());

double[,] randomArray = new double[m,n];

Console.Write("Введите позицию строки: ");
int m2 = int.Parse(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int n2 = int.Parse(Console.ReadLine());


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
        Console.WriteLine();
    }
}
array(m,n);
if (m2<1 || n2<1)
    Console.Write("Позиции строк не могут быть отрицательными");
else if (m2 <= m+1 && n2 <= n+1)
    Console.Write($"Значение элемента равно {randomArray[m2-1,n2-1]:F2} ");
else Console.Write("Такого элемента нет в массиве");