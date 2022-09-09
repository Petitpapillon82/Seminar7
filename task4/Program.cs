/*
Задача 51: Найти сумму по главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

*/ 

Console.Clear();
Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());
int [,] array = FillArray(rows, columns, -9 , 10);
PrintArray(array);
Console.WriteLine();
DiagonalArray(array);
void DiagonalArray(int [,] array)
{
 int[] Sum = new int[Math.Min(rows,columns)];
 int sum = 0;
 for(int i = 0; i < Math.Min(rows,columns); i++)
 {
 sum += array[i, i];
 Sum[i] = array[i, i];
  }
Console.WriteLine($"Сумма элементов диагонали:");
Console.Write($"({String.Join(") + (", Sum)})");
Console.WriteLine($" = {sum}");
}
int [,] FillArray(int rows, int columns, int min, int max)
{
 int[,] array = new int[rows,columns];
 for(int i = 0; i < rows; i++)
 {
 for(int j = 0; j< columns; j++)
 {
 array[i,j] = new Random().Next(min, max);
 }
 }
 return array;
}
void PrintArray(int [,] filledArray)
{
 for(int i = 0; i<filledArray.GetLength(0);i++)
 {
 for(int j = 0; j < filledArray.GetLength(1);j++)
 {
 if (filledArray[i,j] >= 0)
 Console.Write($"{filledArray[i,j]} ");
 else
 Console.Write($"{filledArray[i,j]} ");
 }
 Console.WriteLine();
 }
}
