// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m,n]; //[rows, columns ];
GetRandomMatrix(matrix);

void GetRandomMatrix(double[,] matrix)
{
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
        }                
    } Console.WriteLine();

}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}


 PrintMatrix(matrix);

if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("ТАКОГО ЭЛЕМЕНТА НЕ СУЩЕСТВУЕТ");
}
else
{
    Console.WriteLine($"ЗНАЧЕНИЯ {n} и {m} РАВНЫ: {matrix[n-1, m-1]}");
}                                      
                                     

