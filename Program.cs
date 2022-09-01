//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double[,] CreateArray(int str, int col)
{
double[,] array = new double[str, col];
Random rnd = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
            Console.Write($"{array[i, j]:N2}  ");
        }
        Console.WriteLine();
    }
    
    return array;

}

Console.Write("Please input number of array's strings: ");
int strings = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of array's columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

CreateArray(strings, columns);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
/*
int[,] CreateArray(int str, int col)
{
    int[,] array = new int[str, col];
    Random rnd = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(0,99);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    return array;
}

double Poisk(int[,] indArr, int indI, int indJ)
{
    double znach = 0.001;
    if (indI <= indArr.GetLength(0) || indJ <= indArr.GetLength(1)) znach = indArr[indI, indJ];
    return znach;
}

Console.Write("Please input number of array's strings: ");
int strings = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of array's columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Please input index i (starting with 0): ");
int indexI = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input index j (starting with 0): ");
int indexJ = Convert.ToInt32(Console.ReadLine());

double indexes = Poisk(CreateArray(strings, columns), indexI, indexJ);
if (indexes != 0.001) Console.WriteLine($"Element with indexes [{indexI}, {indexJ}] is {indexes}");
    else Console.WriteLine("There is no such element in this array. You input invalid indexes.");

*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int[,] CreateArray(int str, int col)
{
    int[,] array = new int[str, col];
    Random rnd = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(0,99);
        }
    }
    return array;
}

void SredArifm(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        double average = 0;
        for (int j = 0; j < array2.GetLength(1) ; j++)
        {
            Console.Write($"{array2[i, j]}  ");
            average = average + array2[i, j];
        }
        Console.WriteLine($" average of this string is = {average / array2.GetLength(1)}  ");
        
    }
}

Console.Write("Please input number of array's strings: ");
int strings = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of array's columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

SredArifm(CreateArray(strings, columns));
*/