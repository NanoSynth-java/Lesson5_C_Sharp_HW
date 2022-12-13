//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int [4];
// int count = 0;
// int size = array.Length;

// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     if(array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"{String.Join(", " ,array)} {"->"} {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] array = new int [4];
// int sum = 0;
// int size = array.Length;

// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(1,100);
//     if (i % 2 == 1)
//     {
//         sum += array[i];
//     }
// }
// Console.WriteLine($"{String.Join(", " ,array)} {"->"} {sum}");