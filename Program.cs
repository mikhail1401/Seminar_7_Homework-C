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


Console.WriteLine("\nTask 50");
// Напишите программу, которая на вход принимает позиции элемента
// в двемерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] table = new int[3, 4];

Console.Write("Etner a row number: ");
int row_num = Convert.ToInt32(Console.ReadLine());

Console.Write("Etner a column number: ");
int column_num = Convert.ToInt32(Console.ReadLine());

bool trigger = false;
int num = 0;

for (int row=0; row<table.GetLength(0); row++)
{
    for (int column=0; column<table.GetLength(1); column++)
    {
        table[row, column] = new Random().Next(-10, 11);

        Console.Write(table[row, column] + " ");

        if (row==row_num && column==column_num)
        {
            trigger = true;
            num = table[row, column];
        }
    }
    Console.WriteLine();
}

if (trigger==true)
{
    Console.WriteLine($"The number is {num}");
}
else
{
    Console.WriteLine("There is no such number in the array");
}