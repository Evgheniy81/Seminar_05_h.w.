// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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
int GetSumOfIndexOdd(int [] array)
{ 
    int sum = 0; 
    for (int i = 0; i < array.Length; i++) 
    {
        if (i %2 == 1)
        {
            sum =sum+array[i];
        }
    } 
    return sum; 
} 
int [] arr = CreateArray(10,-10,10);  
int sum = GetSumOfIndexOdd(arr);  
Console.WriteLine($"Сумма нечетных элементов массива = {sum}");