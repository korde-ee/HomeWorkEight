// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8

int[,] CreateRandom2dArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, cols];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

int[,] Create2dUnicTwoDigitsArray (int rows, int cols)
{
   int[,] newArray = new int[rows, cols];
        for(int j = 0; j < rows; j++)
        {
            for(int k = 0; k < cols; k++)
            {
                int newRandomValue = new Random().Next(10, 100);
                newArray[j,k] = newRandomValue;
                for(int l = 0; l < k; l++)
                {
                    if(newArray[j,k] == newArray[j,l]) k--;
                }
            }
            
        }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Show3DArray(int[,,] array)
{
    for(int z = 0; z < array.GetLength(0); z++)
    {
        for(int i = 0; i < array.GetLength(1); i++)
        {
            for(int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write(array[z,i,j] + " ");
            }
            Console.WriteLine();
    }   
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Show3DArrayIndex(int[,,] array)
{
    for(int z = 0; z < array.GetLength(0); z++)
    {
        for(int i = 0; i < array.GetLength(1); i++)
        {
            for(int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write(array[z,i,j] + "(" + z + "," + i + "," + j + ")" + " ");
            }
            Console.WriteLine();
    }   
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] OrderRow2dArray(int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,j] > array[i,k])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}
/*
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальне значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] array = CreateRandom2dArray(m, n, min, max);
Show2DArray(array);
*/
/*
int[,] revers = OrderRow2dArray(array);
Show2DArray(revers);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int MinSumRow(int[,] array)
{
    int sum = 0;
    int row = 0;

    int countRow = array.GetLength(0);
    int[] sumArray = new int[countRow];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i] = sumArray[i] + array[i, j];
        }
    }

    for(int l = 0; l < sumArray.Length; l++)
    {
        Console.Write(sumArray[l] + " ");
    } 

    int min = sumArray[0];

    for(int k = 1; k < sumArray.Length; k++)
    {
        if (sumArray[k] < min)
            {
                min = sumArray[k];
                row = k+1;
            }
    }
    return row;
}
/*
int result = MinSumRow(array);
Console.WriteLine($"Строка с минимальной суммой элементов: {result}");
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] MultiplTwo2dArray(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] result = new int[arrayOne.GetLength(0), arrayOne.GetLength(1)];
    for(int i = 0, j = 0; i < arrayOne.GetLength(0); i++, j++)
    {
        for(int k = 0; k < arrayOne.GetLength(1); k++)
        {
            result[i,k] = arrayOne[i,k] * arrayTwo[j, k];
        }
    }
    return result;
}
/*
int[,] firstArray = CreateRandom2dArray(4, 4, 1, 9);
Show2DArray(firstArray);
int[,] secondArray = CreateRandom2dArray(4, 4, 1, 9);
Show2DArray(secondArray);

int[,] multiArray = MultiplTwo2dArray(firstArray, secondArray);
Show2DArray(multiArray);
*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)

int[,,] Create3dUnicTwoDigitsArray (int z, int rows, int cols)
{
   int[,,] newArray = new int[z, rows, cols];
    for(int i = 0; i < z; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            for(int k = 0; k < cols; k++)
            {
                int newRandomValue = new Random().Next(10, 100);
                newArray[i,j,k] = newRandomValue;
                for(int l = 0; l < k; l++)
                {
                    if(newArray[i,j,k] == newArray[i,j,l]) k--;
                }
            }
        }
    }
    return newArray;
}

int[,,] my3dArray = Create3dUnicTwoDigitsArray(2,2,2);
Show3DArrayIndex(my3dArray);

//Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] CreateSpiralArray(int rows, int cols)
{
    int[,] spiralArray = new int[rows, cols];
    int n = rows;
    int m = cols;
    int c = 0, i = 0, j = 0;
    int k = 1;
    int numb = rows * cols;
    while (k < numb) 
    {
        for (j = c; j < m; j++) 
        {
            if (k == numb + 1)
                break;
            spiralArray[i, j] = k;
            k++;
        }
        j--;
        for (i = c + 1; i < n; i++)
        {
            if (k == numb + 1)
                break;
            spiralArray[i, j] = k;
            k++;
        }
        i--;
        for (j = m - 2; j >= c; j--)
        {
            if (k == numb + 1)
                break;
            spiralArray[i, j] = k;
            k++;
        }
        j++;
        for (i = n - 2; i >= c + 1; i--)
        {
            if (k == numb + 1)
                break;
            spiralArray[i, j] = k;
            k++;
        }
        c++;
        n--;
        m--;
        i = c;
    }
    return spiralArray;
}

/*
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateSpiralArray(row,col);
Show2DArray(myArray);
*/

