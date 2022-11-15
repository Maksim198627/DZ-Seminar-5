//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
System.Console.Write("Введите число элементов массива: ");
int elcount = int.Parse(Console.ReadLine()!);
float[] array = Mass(elcount);
System.Console.WriteLine();
System.Console.WriteLine("Результат: " + RaznicaMinMaxInArray(array).ToString("0.##").Replace(",", "."));

float[] Mass(int elcount)
{
    float[] array1 = new float[elcount];
    Random random = new Random();
    System.Console.Write("Сформированный массив:");
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = random.NextSingle() * (10 - 6) + 6;
        System.Console.Write(array1[i].ToString("0.##").Replace(",", "."));

        if (i < array1.Length - 1) System.Console.Write("; ");

    }
    return array1;
}

float RaznicaMinMaxInArray(float[] array)
{
    float min = array[0];
    float max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}
System.Console.ReadKey();