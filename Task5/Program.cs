using System;
using MyClasses;
using static System.Console;

Clear();


int value = 1;

int[,] array = new int[8, 8];

// заполняем периметр по часовой стрелке
for(int column = 0; column < array.GetLength(1); column++) {
    array[0,column] = value;
    value++;
}

for(int row = 1; row < array.GetLength(0); row++) {
    array[row, array.GetLength(1) - 1] = value;
    value++;
}

for(int column = array.GetLength(1) - 2; column >= 0; column--) {
    array[array.GetLength(0) - 1, column] = value;
    value++;
}

for(int row = array.GetLength(0) - 2; row >= 1; row--) {
    array[row, 0] = value;
    value++;
}

// заполняем середину
int cRow = 1;
int cColumn = 1;

while (value < array.GetLength(0) * array.GetLength(1)) {
    while(array[cRow, cColumn + 1] == 0) {
        array[cRow, cColumn] = value;
        value++;
        cColumn++;
    }
    while(array[cRow + 1, cColumn] == 0) {
        array[cRow, cColumn] = value;
        value++;
        cRow++;
    }
    while(array[cRow, cColumn - 1] == 0) {
        array[cRow, cColumn] = value;
        value++;
        cColumn--;
    }
    while(array[cRow - 1, cColumn] == 0) {
        array[cRow, cColumn] = value;
        value++;
        cRow--;
    }
}

for (int row = 0; row < array.GetLength(0); row++) {
    for (int column = 0; column < array.GetLength(1); column++) {
        if (array[row, column] == 0) {
            array[row, column] = value;
        }
    }
}

ArrayUtils.Print(array);