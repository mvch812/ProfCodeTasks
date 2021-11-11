// Имеется числовой массив A. Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// 1.1.	возрастания
// 1.2.	приближения к числу 12
// 1.3.	знакочередования


Console.WriteLine();

void FillArrayA(int minValue, int maxValue, int[] A) // Метод, заполняющий массив A случайными двузначными целыми числами от minValue до maxValue
{
    int index = 0;
    while (index < A.Length)
    {
        A[index] = new Random().Next(minValue, maxValue);
        index++;
    }
}
int[] A = new int[20];
Console.WriteLine("Случайный массив:");
FillArrayA(-100, 100, A);
PrintArray(A);

void PrintArray(int[] A)
{
    int index = 0;
    while (index < A.Length)
    {
        Console.Write($"{A[index]} ");
        index++;
    }
}


int[] B = new int[A.Length]; //Заполняем массив B для подзадачи 1.1.

int indexB = 1;
int max = A[0];
B[0] = A[0];
for (int index = 1; index < A.Length; index++)
{
    if (A[index] > max)
    {
        max = A[index];
        B[indexB] = A[index];
        indexB++;
    }
}
Array.Resize(ref B, indexB);
//Печатаем массив B, по условию подзадачи 1.1.
Console.WriteLine();
Console.WriteLine("1.1.Массив B, созданный на основе массива A путем отбрасывания элементов, нарушающих порядок возрастания:");
PrintArray(B);


// //Определяем длину массива B для подзадачи 1.2:
// int countLengthC = 0;
// for (int index = 0; index < A.Length; index++)
// {
//     if (A[index] <= 8)
//     {
//         countLengthC++;
//     }
// }
// int[] C = new int[countLengthC]; //Заполняем массив B для подзадачи 1.2.

// int indexC = 0;
// for (int index = 0; index < A.Length; index++)
// {
//     if (A[index] <= 8)
//     {
//         C[indexC] = A[index];
//         indexC++;
//     }
// }


// //Печатаем массив B, по условию подзадачи 1.2.
// Console.WriteLine();
// Console.WriteLine("Массив B, созданный на основе массива A путем отбрасывания элементов, больших восьми:");
// PrintArray(C);

int[] C = new int[A.Length]; //Заполняем массив B для подзадачи 1.2.

if (A[0] <= 12)
{
    int indexC = 1;
    max = A[0];
    C[0] = A[0];
    for (int x = 1; x < A.Length; x++)
    {
        if ((A[x] > max) && (A[x] <= 12))
        {
            max = A[x];
            C[indexC] = A[x];
            indexC++;
        }
    }
    Array.Resize(ref C, indexC);
}
else 
{
  Console.WriteLine("1.2.Массив B, соответствующий условию 1.2. создать невозможно, т.к. 0-й элемент массива уже превышает 12");  
}

Console.WriteLine();
Console.WriteLine("1.2.Массив B, созданный на основе массива A путем отбрасывания элементов, нарушающих порядок приближения к 12:");
PrintArray(C);

bool Znak(int j)
{
    return j >= 0;
}

int[] D = new int[A.Length]; //Заполняем массив B для подзадачи 1.3.

int indexD = 1;
D[0] = A[0];
for (int index = 1; index < A.Length; index++)
{
    if (Znak(A[index]) != Znak(A[index - 1]))
    {
        D[indexD] = A[index];
        indexD++;
    }
}
//Печатаем массив B, по условию подзадачи 1.3.
Array.Resize(ref D, indexD);
Console.WriteLine();
Console.WriteLine("1.3.Массив B, созданный на основе массива A путем отбрасывания элементов, нарушающих знакочередование:");
PrintArray(D);
