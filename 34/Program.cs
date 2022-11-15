//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2




System.Console.Write("Введите число элементов массива: ");
int elcount = int.Parse(Console.ReadLine()!);
int[] array = Mass(elcount);
System.Console.WriteLine();
System.Console.WriteLine("Результат: " + SummPositiveValuesInArray(array));

int[] Mass(int elcount)
{
    int[] array1 = new int[elcount];
    Random random = new Random();
    System.Console.Write("Сформированный массив:");
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = random.Next(100, 999);
        System.Console.Write(array1[i]);

        if (i < array1.Length - 1) System.Console.Write(",");

    }
    return array1;
}

int SummPositiveValuesInArray(int[] array)
{
    int summa1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) summa1++;
       
    }
    return summa1;
}
System.Console.ReadKey();
