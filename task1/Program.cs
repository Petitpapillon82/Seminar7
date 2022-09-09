//Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

Console.Clear();

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int [,] array = FillArray(rows, columns, 1 , 10);

PrintArray(array);

int [,] FillArray(int rows, int columns, int min, int max){
    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int [,] filledArray){
    for(int i = 0; i<filledArray.GetLength(0);i++){
        for(int j = 0; j < filledArray.GetLength(1);j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

