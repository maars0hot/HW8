// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] resultArray = CreateArrayMatrix(3,4, 1,5 );
PrintArray(resultArray);
Console.WriteLine();
RowWithMinSum(resultArray);
Console.WriteLine();

void RowWithMinSum(int[,] matrix)
{
    int minRow = 0;
    int minSumRow=0;
    int sumRow=0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow+= resultArray[0,i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumRow+= resultArray[i,j];
        if(sumRow<minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow=0;
    }
     Console.Write($"{minSumRow + 1} строка");
}


void PrintArray(int[,] arr)
{

for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
if (i < arr.Length - 1) Console.Write($"{arr[i, j],3} ");
else Console.Write($"{arr[i, j]}");
}
Console.WriteLine();
}
}

int[,] CreateArrayMatrix(int rows, int colum, int min, int max)
{
int[,] arr = new int[rows, colum];
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = rnd.Next(min, max + 1);
}
}
return arr;
}
