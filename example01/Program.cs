// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InitArray()
{
    Console.Write("Введите количество чисел:\t");
    int elementsCount = int.Parse(Console.ReadLine()??"");
    int[] myArray = new int[elementsCount];
    
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите число:\t");
        myArray[i] = int.Parse(Console.ReadLine()??"");
    }
    return myArray;
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int Result( int[] array)

{
    int num = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
        num++;
        }
    }
    return num;

}

int[] array = InitArray();
int myArray = Result(array);
Print(array);
Console.WriteLine($"Количество чисел больше нуля = {myArray}");
