// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
int rows = 4; // кол-во строк
int colums = 4; // кол-во столбцов
int[,] array = GetArray(rows, colums, 10,20);
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

int [,] SelectionSort(int[,]array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    int min = 0;
    //int[,] TempArr = new int[rows,colums];
    for (int i = 0; i < rows; i++)
    {
    for (int j = 0; j < colums-1; j++)
    { 
    //for (int k = i; k < colums; k++)
    //{
    //for (int m = j + 1; m < colums/2; m++)
    //{  
    //TempArr[k,m] = array[i,j];
    for (int count = 0; count < colums*rows; count++)
    {  
    if(array[i,j] <= array[i,j +1])  
    {
    min = array[i,j];
    array[i,j] = array[i,j+1];
    array[i,j+1] = min;
    }
    }
    }
    }  
    return array; 
}

PrintArray(array);
SelectionSort(array);
Console.WriteLine();
PrintArray(array);

