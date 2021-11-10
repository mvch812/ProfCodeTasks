// Задача 16
// Сформировать случайным образом N-элементный массив, заполненный однозначными целыми числами разных знаков. Задать k и выяснить
// 1.1.	сколько раз повторяется k в массиве
// 1.2.	сколько элементов находится между первым и последним k
// 1.3	сколько раз встречается k

void FillArrayA(int[] A)
{
    int length = A.Length;
    int index = 0;
    while (index < length)
    {
        A[index] = new Random().Next(-10, 10);
        index++;
    }
}

void PrintArray(int[] A) // Метод, печатающий массив A  
{
    int index = 0;
    while (index < A.Length)
    {
        {
            Console.Write($"{A[index]} ");
        }
        index++;
    }
}

int[] A = new int[10];
FillArrayA(A);
Console.WriteLine();
Console.WriteLine("Случайно сформированный массив:");
PrintArray(A);
Console.WriteLine();
Console.WriteLine("Введите число k:");
int k = Convert.ToInt32(Console.ReadLine());

int countK(int[] A)
{
    int count = 0;
    for (int x = 0; x < A.Length; x++)
    {
        if (A[x] == k)
        {
            count++;
        }
    }
    return count;
}

int FirstIndexK(int[] A)
{
    for (int x1 = 0; x1 < A.Length; x1++)
    {
        if (A[x1] == k)
        {
            return x1 + 1;
        }
    }
    return 0;
}

int SecondIndexK(int[] A)
{
    for (int x2 = 0; x2 < A.Length; x2++)
    {
        if (A[A.Length - 1 - x2] == k)
        {
            return A.Length - x2;
        }
    }
    return 0;
}
Console.WriteLine(SecondIndexK(A));
Console.WriteLine(FirstIndexK(A));
if (countK(A) >= 2)
{
    Console.WriteLine($"1.1.Число {k} повторяется  {countK(A) - 1} раз");
    Console.WriteLine($"1.2.Между первым и последним числом k={k}  {Math.Abs(SecondIndexK(A) - FirstIndexK(A)) - 1} элементов");
    Console.WriteLine($"1.3.Число {k} встречается {countK(A)} раз");
}
else
{
    if (countK(A) == 1)
    {
        Console.WriteLine($"1.1.Число {k} не повторяется в массиве.");
        Console.WriteLine($"1.2.Число k={k} не повторяется в массиве");
        Console.WriteLine($"1.3.Число {k} встречается {countK(A)} раз");
    }
    else
    {
        Console.WriteLine($"1.1.Число {k} не встречается в массиве.");
        Console.WriteLine($"1.2.Число {k} не встречается в массиве.");
        Console.WriteLine($"1.3.Число {k} не встречается в массиве.");
    }
}
