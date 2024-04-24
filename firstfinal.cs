// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
// Обычный комментарий к 1 строчке кода или к нескольким 
/// Комментарий к методу -  summary
/// <summary> (что делает метод)
/// Метод создает двумерный массив, заполненный случайными числами
/// </summary>
/// <param name="m">Количество строчек</param> (описание параметра 1)
/// <param name="n">Количество столбцов</param> (описание параметра 2)
/// <param name="min">Минимальное рандомное число в двумерном массиве</param>(описание параметра 3)
/// <param name="max">Максимальное рандомное число в двумерном массиве</param>(описание параметра 4)
/// <returns> 
/// Получаем двумерный массив, заполненный
/// случайными числами (что возвразает метод с помощью return)
/// </returns>
int[,] array2D = GetMatrix(rows, columns, 0, 10); // Вызов метода
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; // Матрица: m строк и n столбцов
    for (int i = 0; i < m; i++) // m = matrix.GetLenth(0) - строчки
    {
        for (int j = 0; j < n; j++) // n = matrix.GetLenth(1) - столбцы
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
PrintMatrix(array2D);
/// <summary>
/// Метод печатает матрицу на экран
/// </summary>
/// <param name="array">Табличка, которую будем выводить в консоль </param>
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            Console.Write(array[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
        }
        Console.WriteLine(); // Переход на новую строчку
    }
}

/// <summary>
/// метод принимает двумерный массив на вход, производит замену
/// 1 и последней строчки и сохраняет результат в память
/// </summary>
/// <param name="matrix">Двумерный массив</param>
void ChangeMatrix(int[,] matrix)
{
    // 1    2      3
    // 4    5      6
    // 7    8      9
    int lastRow = matrix.GetLength(0) - 1; // matrix = new int[3(стр),3], 3 - 1 = 2
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i]; // temp = 1
        matrix[0, i] = matrix[lastRow, i]; // matrix[0,0] = matrix[2,0]
            // 7    2      3
            // 4    5      6
            // 7 (temp = 1)   8      9
        matrix[lastRow, i] = temp;
    }
}

Console.WriteLine("Матрица, в которой поменяли местами 1 и последнюю строчки: ");
ChangeMatrix(array2D); // Этот массив изменяется и в  этом же массиве происходит замена строк
PrintMatrix(array2D);
