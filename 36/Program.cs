//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
System.Console.Write("Введите число элементов массива: ");
int elcount = int.Parse(Console.ReadLine()!);
int[] array = Mass(elcount);
System.Console.WriteLine();
System.Console.WriteLine("Результат: " + SummOddValuesInArray(array) );

int[] Mass(int elcount)
{
    int[] array1 = new int[elcount];
    Random random = new Random();
    System.Console.Write("Сформированный массив:");
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = random.Next(1, 30);
        System.Console.Write(array1[i]);

        if (i < array1.Length - 1) System.Console.Write(",");

    }
    return array1;
}
int SummOddValuesInArray(int[] array)
{
    int summa1 = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        summa1 += array[i];
    }
    return summa1;
}
System.Console.ReadKey();






