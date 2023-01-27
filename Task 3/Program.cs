// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Вариант метода, когда массив задается рандомно:

// int[] GetArray(int lengthArr)
// {
//     int[] array = new int[lengthArr];
//     for (int i = 1; i < lengthArr; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }

//Вариант, когда массив вводит пользователь

PrintArray(GetArray(8));

int[] GetArray(int lengthArr)
{
    int[] array = new int[lengthArr];
    for (int i = 1; i < lengthArr; i++)
    {
        System.Console.WriteLine("Введите число массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("Вы ввели массив: ");
    System.Console.Write("[");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    System.Console.WriteLine("]");
}