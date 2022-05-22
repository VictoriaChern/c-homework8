namespace MyClasses;
public class ArrayUtils {

    public static int[,] GetArray(int rows, int column, int max) {
        return GetArray(rows, column, 0, max);
    }
    public static int[,] GetArray(int rows, int column, int min, int max) {
        int[,] array = new int[rows,column];
        Random random = new Random();
        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < column; j++) {
                array[i,j] = random.Next(min,max);
            }
        }
        return array;
    }

    public static void Print(int[,] array) {
        for(int i = 0; i < array.GetLength(0); i++) {
            for(int j = 0; j < array.GetLength(1); j++) {
               Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void PrintWithRowNum(int[,] array) {
        for(int i = 0; i < array.GetLength(0); i++) {
            Console.Write($"{i}: ");
            for(int j = 0; j < array.GetLength(1); j++) {
               Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void Print(int[] array) {
        for(int i = 0; i < array.Length; i++) {
               Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    public static void PrintWithIndex(int[] array) {
        for(int i = 0; i < array.Length; i++) {
               Console.Write($"{i}) {array[i]} ");
        }
        Console.WriteLine();
    }
}
