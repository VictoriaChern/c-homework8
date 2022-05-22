using System;
using MyClasses;
using static System.Console;

Clear();

int[,] array1 = ArrayUtils.GetArray(4,4,10);
int[,] array2 = ArrayUtils.GetArray(4,4,10);

WriteLine("Первая матрица:");
ArrayUtils.Print(array1);
WriteLine("Вторая матрица:");
ArrayUtils.Print(array2);
WriteLine("Произведение двух матриц:");
ArrayUtils.Print(MultArray(array1, array2));

int[,] MultArray(int[,] array1, int[,]array2) {
    int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++) {
        for(int j = 0; j < array1.GetLength(1); j++) {
            result[i,j] = array1[i,j] * array2[i,j];
        }
    }
    return result;
}