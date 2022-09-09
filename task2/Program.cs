/*Решение в группах задачи:

Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

Console.Clear();

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int [,] array = FillArray(rows, columns);
PrintArray(array);


int [,] FillArray(int rows, int columns){
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = i + j;
        }
    }
    return array;
}

void PrintArray(int [,] filledArray){
    for(int i = 0; i<filledArray.GetLength(0);i++){
        for(int j = 0; j < filledArray.GetLength(1);j++){
            if (filledArray[i,j] / 10 == 0)
            Console.Write($"{filledArray[i,j]}  ");
            else Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

