/* for (int i = 0; i < size; i++) 
{ 
   array[i] = Random.Next(-5.0, 5.0); 
} 
Console.WriteLine($"[{string.Join(", ", array)}]"); 
return array; 
*/

//double [] Array = Console.ReadLine(3.22, 4.2, 1.15, 77.15, 65.2);
//Console.Write($"Ведите пять чисел: ");
//double array = Convert.ToInt32(Console.ReadLine());

/*double[,] Create2dArray(int m, int n)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            arr[i, j] = new Random().Next(1, 10) + Math.Round(new Random().NextDouble(), 2); // можно убрать метод math.round чтобы было больше цифр после запятой
    return arr;
}
*/


//Console.WriteLine($"double: 5.25");
/*double[,] a = new double[5, 10];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}
*/

//int sum = GetSumOfIndexOdd(arr);  
//Console.WriteLine($"Сумма нечетных элементов массива = {sum}");

/* Вывод двумерного массива
double[,] a = new double[5, 10];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        a[i, j] = random.Next(100);
        Console.Write("{0,4}", a[i, j]);
    }
    Console.WriteLine();
}
*/
// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

/*
double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(100000) * 0.001, 3); // Нашел только такой ввывод случайных веществ.чисел
    }
    return array;
}
double[] arr = CreateArray(5, 0, 0);  //Почему вывод чисел не происходит в границах заданного интервала?
Console.WriteLine($"[{string.Join(", ", arr)}]");   //вывод дробной части числа выполняется после ',' а не '.' Например: '29,617' а не '29.617'

double GetMaxNum(double[] array)
{
    double mx = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > mx)
        {
            mx = array[i];
        }
        return mx;
    }

}
double mx = GetMaxNum(arr);
Console.WriteLine($" {mx}");
*/

/*for (int i = 0; i < length; i++)
{
    double mx = array(1);
    double mn = array(1);
    if (array[i] > mx)
    {
        mx == array(i);
    }
    if (array[i] < mn)
    {
        mn == array(i);
    }
    return mx;
    return mn;

}
*/

//Console.WriteLine(mx);
//Console.WriteLine(mn);

//float[] B = new float[50];

// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

//Difference


/*double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(1000) * 0.01, 2); // Нашел только такой ввывод случайных веществ.чисел
    }
    return array;
}
double[] array = CreateArray(5, 0, 0);  //Почему вывод чисел не происходит в границах заданного интервала?
Console.WriteLine($"[{string.Join(", ", array)}]");   //вывод дробной части числа выполняется после ',' а не '.' Например: '29,617' а не '29.617'
*/
/*
double[] array = { 3.47, 4.2, 1.01, 77.25, 65.28 };
Console.WriteLine($"[{string.Join(", ", array)}]");
int N = array.Length;
int[] array2 = new int[N];
for (int i = 0; i < N; i++)
{
    array2[i] = Convert.ToInt32(array[i]);
}
double max = 0;
double min = 1;
for (int i = 0; i < N; i++)
{
    double num = array[i] - array2[i];

    if (num > max)
    {
        max = num;
    }
    if (num < min)
    {
        min = num;
    }
}
Console.WriteLine($"[{string.Join(", ", array2)}]");
Console.WriteLine(Math.Round(max, 2, MidpointRounding.ToZero));
Console.WriteLine(Math.Round(min, 2, MidpointRounding.ToZero));
double dif = max - min;
Console.WriteLine($"Разность между большим и меньшим дробным значениями данного масива равна: {(Math.Round(dif, 2, MidpointRounding.ToZero))}");
*/

internal class Program
{
    private static void Main(string[] args)
    {
        //double[] array2 
        //int max2 = Convert.ToInt32(max);
        //double mx = max - max2;
        //Console.WriteLine(max);
        //Console.WriteLine("{0: 0.00}", max);
        //Console.WriteLine("{0:F4}", max);
        //Console.WriteLine("{0:f}", max);
        //Console.WriteLine(Math.Round(max, 3, MidpointRounding.ToZero));
        //double a = new Random().NextDouble();
        int a = (int)4.55;
        Console.WriteLine(a);
    }
}
// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
/////Данная прога работает только для значений после запятой < 5. 
/////Если значение больше то округляется в большую сторону и решение не верно

double[] array = { 3.47, 4.2, 1.01, 77.25, 65.28 };
Console.WriteLine($"[{string.Join(", ", array)}]");
int N = array.Length;
int[] array2 = new int[N];
for (int i = 0; i < N; i++)
{   
    array2[i] = Convert.ToInt32(array[i]); //как сдесь конвертировать например 4.55 чтоб не получить 5 ?
    /*
    double b = array[i];
    int a = (int)b;
    array2[i] = a;
    */
}
Console.WriteLine($"[{string.Join(", ", array2)}]"); 
    return array;
double max = 0;
double min = 1;
for (int i = 0; i < N; i++)
{
    double num = array[i] - array2[i];

    if (num > max)
    {
        max = num;
    }
    if (num < min)
    {
        min = num;
    }
}
//Console.WriteLine($"[{string.Join(", ", array2)}]");
Console.WriteLine(Math.Round(max, 2, MidpointRounding.ToZero));
Console.WriteLine(Math.Round(min, 2, MidpointRounding.ToZero));
double dif = max - min;
Console.WriteLine($"Разность между большим и меньшим дробным значениями данного масива равна: {(Math.Round(dif, 2, MidpointRounding.ToZero))}");

/////////////////////////////////////
// Рандомный способ заполнения массива
/*
double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble(); //таким методом можно получить числа [0.0, 1)
        //array[i] = Math.Round(rand.Next(1000) * 0.01, 2); // Нашел только такой ввывод случайных веществ.чисел
    }

    return array;
}
double[] array = CreateArray(5, 1, 5);  //Почему вывод чисел не происходит в границах заданного интервала?
Console.WriteLine($"[{string.Join(", ", array)}]");   //вывод дробной части числа выполняется после ',' а не '.' Например: '29,617' а не '29.617'
*/
/////////////// Как пример.
/*
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
    */