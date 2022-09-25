// Задача 54: Поменять 1 и последнюю строку двумерного массива

int rows = 7; // кол-во строк
int colums = 6; // кол-во столбцов
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
    int[] TempArr = new int[rows];
    for (int i = 0; i < colums; i++)
    {
    TempArr[i] =  array[0,i];
    array[0,i] = array[rows -1,i];
    array[rows -1,i] =  TempArr[i];
    }
    return array;
}
    
    //}
    //}
PrintArray(array);
SelectionSort(array);
Console.WriteLine();
PrintArray(array);
