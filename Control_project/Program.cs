Console.WriteLine("Данная программа из введённого пользователем массива строк формирует массив строк, длина которых не превышает 3 символа.");
Console.WriteLine("==========================================");
Console.Write("Введите желаемое количество строк массива: ");

int numberStrings = int.Parse(Console.ReadLine());
string[] array = new string[numberStrings];
string[] collection = new string[numberStrings];
int i = 0;
int count = 0;

void FillArray()
{
    int numberStrings = array.Length;
    while (i < numberStrings)
    {
        Console.Write($"Введите символы {i+1}-й строки: ");
        array[i] = Console.ReadLine();
        if (array[i] == string.Empty)
        {
            Console.Write("Упс, строка должна содержать хотя бы один символ, ");
            Console.Write("попробуйте ещё разок: ");
            array[i] = Console.ReadLine();
        }
        i++;
    }
}

void SortArray()
{
    for (int i = 0; i < numberStrings; i++)
    {
        if (array[i].Length <= 3)
        {
            collection[count] = array[i];
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

FillArray();
Console.WriteLine();
Console.Write("Исходный массив строк: ");
PrintArray(array);
SortArray();
Console.WriteLine("==========================================");
Console.Write("Итоговый массив строк: ");
PrintArray(collection);