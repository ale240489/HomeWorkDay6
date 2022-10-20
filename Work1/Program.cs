// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько
//чисел больше 0 ввел пользователь.

int[] InitialArray ()
{
    Console.WriteLine("Введите числа, через пробел");
    string [] arrNew = Console.ReadLine().Split(' ');
    int [] arr = new int[arrNew.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(arrNew[i]);
    }
    return arr;
}

void PrintArray (int[]array)
{
    Console.WriteLine();
    Console.WriteLine("Получившийся массив");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");    
    }
}

int PositivNum (int[] array)
{
    int numPositiv = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            numPositiv+=1;
    }
    return numPositiv;
}


int[] array = InitialArray();
PrintArray(array); 
int positivNum = PositivNum(array);
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел = {positivNum}");