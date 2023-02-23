// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.


string[] array1 = new string[7] { "9", "five", "27", "377", "ten", "3762", "one" };
string[] array2 = new string[array1.Length];

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}
SecondArray(array1, array2);
Console.WriteLine();
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(array2);
Console.WriteLine();
