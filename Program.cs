Console.WriteLine("Task 47");
// Задайте двумерный массив размером mxn, заполненный
// случайными вещественными числами
// m=3, n=4
// 0,7 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Enter a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];

for (int row=0; row<matrix.GetLength(0); row++)
{
    for (int column=0; column<matrix.GetLength(1); column++)
    {
        // matrix[row, column] = new Random().NextDouble() * 100;
        matrix[row, column] = new Random().NextDouble() + new Random().Next(-100, 100);
        Console.Write(matrix[row, column] + "  ");
    }
    Console.WriteLine();
}
