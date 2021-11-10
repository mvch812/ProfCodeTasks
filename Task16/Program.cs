// Задача 16
// Сформировать случайным образом N-элементный массив, заполненный однозначными целыми числами разных знаков. Задать k и выяснить
// •	сколько раз повторяется k в массиве
// •	сколько элементов находится между первым и последним k
// •	сколько раз встречается k

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
PrintArray(A);
Console.WriteLine();
Console.WriteLine("Введите число k:");
int k = Convert.ToInt32(Console.ReadLine());

int countPowt(int[] A)
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
Console.WriteLine($"Число {k} повторяется {countPowt(A)} раз(а)");