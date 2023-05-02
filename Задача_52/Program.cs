/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
int n = 3; 
int m = 5; 
Random random = new Random();
int[,] Arr = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < Arr.GetLength(0); i++)
{
    for (int j = 0; j < Arr.GetLength(1); j++)
{
    Arr[i, j] = random.Next(1, 10);
Console.Write("{0} ", Arr[i, j]);
}
Console.WriteLine();
}
Console.WriteLine("");
//Console.WriteLine(Arr.GetLength(0));
for (int j = 0; j < Arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        sum = sum + Arr[i, j];
    }
    Console.Write($"{ sum / Arr.GetLength(0):G2} ");
}