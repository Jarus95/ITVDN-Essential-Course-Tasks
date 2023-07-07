
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
//Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
//среднее арифметическое всех элементов, вывести все нечетные значения.

Random random = new Random();
Console.Write("количество элементов: ");
string str = Console.ReadLine();
int N = 0;
try
{
     N = int.Parse(str);
}
catch (Exception)
{
	throw;
}

var array = new int[N];
for (int i = 0; i < N; i++)
{
    array[i] = random.Next(1, 60);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write( array[i] + " ");
}
Console.WriteLine();
Console.WriteLine(new string('-', 30));
int max = 0;
for (int i = 0;i < array.Length; i++)
{
    if (max < array[i])
        max = array[i];
}
Console.WriteLine("Max: " + max);

int min = int.MaxValue;
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i])
        min = array[i];
}
Console.WriteLine("Min: " + min);

int Sum = 0;
for (int i = 0; i < array.Length; i++)
{
    Sum += array[i];
}
Console.WriteLine("Sum: " + Sum);

int AVG = Sum/array.Length;

Console.WriteLine("AVG: " + AVG);
Console.WriteLine(new string('-', 30));
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
        Console.Write(array[i] +" ");
}
Console.WriteLine();