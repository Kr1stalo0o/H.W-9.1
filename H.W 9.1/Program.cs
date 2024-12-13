////.1.

//class Program
//{
//    static void Main()
//    {
//        int[] array = { 10, 20, 30, 40, 50 };

//        if (array.Length < 2)
//        {
//            Console.WriteLine("The array is too small.");
//            return;
//        }

//        int largest = int.MinValue;
//        int secondLargest = int.MinValue;

//        foreach (int num in array)
//        {
//            if (num > largest)
//            {
//                secondLargest = largest;
//                largest = num;
//            }
//            else if (num > secondLargest && num != largest)
//            {
//                secondLargest = num;
//            }
//        }

//        Console.WriteLine($"The second largest element: {secondLargest}");
//    }
//}

////.2.

//class Program
//{
//    static void Main()
//    {
//        int[,] matrix =
//        {
//            { 5, 2, 8 },
//            { 1, 6, 7 },
//            { 3, 4, 9 }
//        };

//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        int[] flatArray = new int[rows * cols];
//        int k = 0;
//        foreach (int num in matrix)
//        {
//            flatArray[k++] = num;
//        }
//        Array.Sort(flatArray);

//        k = 0;
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                matrix[i, j] = flatArray[k++];
//            }
//        }

//        Console.WriteLine("Sorted array:");
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write(matrix[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

////.3.
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] array = { 10, 20, 30, 40, 50 };

//        Console.Write("Enter the index to delete: ");
//        int indexToRemove = int.Parse(Console.ReadLine());

//        if (indexToRemove < 0 || indexToRemove >= array.Length)
//        {
//            Console.WriteLine("Invalid index.");
//            return;
//        }

//        int[] newArray = new int[array.Length - 1];
//        int j = 0;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (i != indexToRemove)
//            {
//                newArray[j++] = array[i];
//            }
//        }

//        Console.WriteLine("Array after deletion:");
//        Console.WriteLine(string.Join(", ", newArray));
//    }
//}

////.4.

//class Program
//{
//    static void Main()
//    {
//        int[,] matrix =
//        {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        int primaryDiagonalSum = 0;
//        int secondaryDiagonalSum = 0;

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            primaryDiagonalSum += matrix[i, i];
//            secondaryDiagonalSum += matrix[i, matrix.GetLength(1) - 1 - i];
//        }

//        Console.WriteLine($"The sum of the diagonals from left to right: {primaryDiagonalSum}");
//        Console.WriteLine($"The sum of the diagonals from right to left {secondaryDiagonalSum}");
//    }
//}
