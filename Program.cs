// Задача 53:
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4
// 5 9 2 3
// 1 4 7 2


// int[,] myArray = GetArray(5, 6);
// PrintArray(myArray);
// Console.WriteLine();
// ReverseLineArray(myArray);
// PrintArray(myArray);


// int[,] GetArray(int n, int m){
//     int[,] array = new int[n, m];
//     for(int i = 0; i < n; i++){
//         for(int j = 0; j < m; j++){
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array){
//      for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void ReverseLineArray(int[,] myArray){
//     int[] bofferArray = new int[myArray.GetLength(1)];
//     for(int i = 0; i < myArray.GetLength(1); i++){
//         bofferArray[i] = myArray[0, i];
//     }
//     for(int i = 0; i < myArray.GetLength(1); i++){
//         myArray[0, i] = myArray[myArray.GetLength(0) - 1, i];
//     }
//     for(int i = 0; i < myArray.GetLength(1); i++){
//         myArray[myArray.GetLength(0) - 1, i] = bofferArray[i];
//     }
// }




// Задача 55:
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы.
// В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// В итоге получается вот такой массив:

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// int[,] myArray = GetArray(4, 4);
// if(myArray.GetLength(0) != myArray.GetLength(1)){
//     Console.WriteLine("Невозможно заменить строки на столбцы!!!");
// }
// else{
// PrintArray(myArray);
// Console.WriteLine();
// int[,] myArray2 = ChangeArray(myArray);
// PrintArray(myArray2);
// }


// int[,] GetArray(int n, int m){
//     int[,] array = new int[n, m];
//     for(int i = 0; i < n; i++){
//         for(int j = 0; j < m; j++){
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array){
//      for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeArray(int[,] myArray){
//     int[,] resultArray = new int[myArray.GetLength(0), myArray.GetLength(1)];
//     for(int i = 0; i < myArray.GetLength(1); i++){
//         for(int j = 0; j < myArray.GetLength(0); j++){
//            resultArray[i, j] = myArray[j, i];
//         }
//     }
//     return resultArray;
// }





// Задача 59:
// Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.

// int[,] myArray = GetArray(4, 4);
// PrintArray(myArray);
// Console.WriteLine();
// int[] indexArray = FindMinElement(myArray);
// int[,] resultArray = ResultArray(indexArray, myArray);
// PrintArray(resultArray);


// int[,] GetArray(int n, int m){
//     int[,] array = new int[n, m];
//     for(int i = 0; i < n; i++){
//         for(int j = 0; j < m; j++){
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array){
//      for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[] FindMinElement(int[,] array){
//     int minEl = array[0, 0];
//     int[] minIndex = new int[2];
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             if(array[i, j] < minEl){
//                 minEl = array[i, j];
//                 minIndex[0] = i;
//                 minIndex[1] = j;
//             }
//         }
//     }
//     return minIndex;
// }

// int[,] ResultArray(int[] indexArray, int[,] array){
//     int[,] resultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     int rows = 0;
//     int column = 0;
//     for(int i = 0; i < array.GetLength(0); i++){
//         if(i == indexArray[0]) continue;       
//         for(int j = 0; j < array.GetLength(1); j++){
//             if(j == indexArray[1]) continue;
//             resultArray[rows, column] = array[i, j];
//             column++;
//         }
//         column = 0;
//         rows++;
//     }
//     return resultArray;
// }




