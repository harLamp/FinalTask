using System;
Console.Clear();
Console.WriteLine($"Итоговая задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.  \n");
Console.Write("Сколько данных Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arraydata1 = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й данные: ");
    string data = Convert.ToString(Console.ReadLine())!;
    arraydata1[i] = data;
}
string[] arraydata2 = new string[arraydata1.Length];
void SecondArray(string[] arraydata1, string[] arraydata2)
{
    int count = 0;
    for (int i = 0; i < arraydata1.Length; i++)
    {
    if(arraydata1[i].Length <= 3)
        {
        arraydata2[count] = arraydata1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(arraydata1, arraydata2);
PrintArray(arraydata2);