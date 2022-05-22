using System;
using MyClasses;
using static System.Console;

Clear();

int[,] array = ArrayUtils.GetArray(4,4,10);
WriteLine("До сортировки:");
ArrayUtils.Print(array);
SortArray(array);
WriteLine("После сортировки:");
ArrayUtils.Print(array);

void SortArray(int[,] array) {
    for(int row = 0; row < array.GetLength(0); row++) {
        bool needSort = true;
        while(needSort) {
            needSort = false;
            for(int column = 0; column < array.GetLength(1) - 1; column++) {
                int v1 = array[row, column];
                int v2 = array[row, column + 1];
                if(v1 < v2) {
                    array[row, column] = v2;
                    array[row, column + 1] = v1;
                    needSort = true;
                }
            }
        }
    }
}