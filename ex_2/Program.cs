// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int rows = 3; // кол-во строк
int colums = 3; // кол-во столбцов
int[,] array = GetArray(rows, colums, 1,20);
int[,] GetArray(int m,int n, int minValue,int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue + 1); 
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int SumRows(int[,]array)
{
    int sum = 0;              
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int  i = 0; i < rows; i++)
    {
    for (int j = 0; j < colums; j++) 
    {   
    sum = sum + array[i,j];
    Console.WriteLine($"{sum} ");  
    }
    }
    
    return sum; 
}
PrintArray(array);
SumRows(array);
Console.WriteLine();
//PrintArray(array);
