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

// Рандомный способ заполнения массива
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