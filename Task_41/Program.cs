// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadInt(string promt)
{
    System.Console.WriteLine(promt);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Num(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"Введите {i + 1}-й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}]={array[i]}");
    }

}

int CountPosNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = ReadInt("Введите количество элементов");
int[] array;
array = Num(length);
PrintArray(array);
System.Console.WriteLine($"Количество чисел больше 0 - {CountPosNum(array)}");
