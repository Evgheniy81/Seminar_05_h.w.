//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] CreateArray(int size, int min, int max)
{ 
    int [] array = new int [size]; 
    Random rand = new Random(); 
 
    for (int i = 0; i < size; i++) 
    { 
        array [i] = rand.Next(min, max); 
    } 
    Console.WriteLine($"[{string.Join(", ", array)}]"); 
    return array; 
} 
int GetCountOfEvenNumbers(int [] array)
{ 
    int count = 0; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] %2 == 0)
        {
            count++;
        }
    } 
    return count; 
} 
int [] arr = CreateArray(10,100,1000);  
int count = GetCountOfEvenNumbers(arr);  
Console.WriteLine($"Количество четных чисел массива = {count}");