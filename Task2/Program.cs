using System;
using MyClasses;
using static System.Console;

Clear();

int[,] array = ArrayUtils.GetArray(6,4,10);
ArrayUtils.PrintWithRowNum(array);
int[] sumArray = SumArray(array);
WriteLine("Суммы строк:");
ArrayUtils.PrintWithIndex(sumArray);
int numOfRow = FindIndexOfMin(sumArray);
WriteLine($"номер строки с наименьшей суммой элементов: {numOfRow} строка");


int FindIndexOfMin(int[] array) {
    int indexOfMin = 0;
    int min = array[indexOfMin];
    for(int i = 1; i < array.Length; i++) {
        if(array[i] < min) {
            min = array[i];
            indexOfMin = i;
        }
    }
    return indexOfMin;

}

int[] SumArray(int[,]array) {
    int[] SumArray = new int[array.GetLength(0)];
  
    for(int row = 0; row < array.GetLength(0); row++) {
        int sum = 0;
        for(int column = 0; column < array.GetLength(1); column++) {
            sum += array[row, column]; 
        }
        SumArray[row] = sum;
    }

    return SumArray;
}