using System;
using MyClasses;
using static System.Console;

Clear();

int[,,] array = { { {12, 13}, {22, 23} }, { {32, 33}, {42, 43} } };

for(int i = 0; i < array.GetLength(0); i++) {
    for(int j = 0; j < array.GetLength(1); j++) {
        for(int k = 0; k < array.GetLength(2); k++) {
            Write($"{array[i,j,k]}({i},{j},{k}) ");
        }
    }
    WriteLine();
}