//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] GenerateArray(int lenght)
{
    int[] newArray = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        newArray[i] = Promt($"введите {i + 1} число ");
    }
    return newArray;
}

int Promt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

int SumNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) { sum = sum + 1; }
    }
    return sum;
}

int lenght = Promt("сколько чисел Вы хотите ввести? - > ");
int[] array1 = GenerateArray(lenght);
PrintArray(array1);
int itogSum = SumNum(array1);
System.Console.WriteLine($"Количество чисел > 0 = {itogSum}");