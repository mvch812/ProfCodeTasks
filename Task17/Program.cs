// Задача 17
// Cформировать случайным образом целочисленный массив из M натуральных двузначных чисел. Найти среднее арифметическое значение A и
// 1.1.	число элементов, меньших A
// 1.2.	два соседних элемента, между которыми находится A
// 1.3.	элемент, наиболее близкий к A

void FillArrayA(int[] A)
{
    int length = A.Length;
    int index = 0;
    while (index < length)
    {
        A[index] = new Random().Next(1, 100);
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
Console.WriteLine("Введите размерность массива (кол-во элементов):");
int s = Convert.ToInt32(Console.ReadLine());

int[] A = new int[s];
FillArrayA(A);

Console.WriteLine("Случайный целочисленный массив из натуральных двузначных чисел:");
PrintArray(A);
Console.WriteLine();

int averageArray(int[] A) //Метод, определяющий ср. арифметическое элементов массива
{
    int length = A.Length;
    int index = 0;
    int summ = 0;
    int average = 0;

    while (index < length)
    {
        summ = summ + A[index];
        index++;
    }
    average = summ / length;
    return average;
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое массива A: " + averageArray(A));

int DoA(int[] A)
{
    int count = 0;
    for (int x = 0; x < A.Length; x++)
    {
        if (A[x] < averageArray(A))
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($"1.1.Число элементов массива меньших чем среднее арифметическое {averageArray(A)} = {DoA(A)}");

void OkoloAverage(int[] A)
{
    for (int x = 0; x < A.Length - 1; x++)
    {
        if ((A[x] < averageArray(A) && A[x + 1] > averageArray(A)) | (A[x] > averageArray(A) && A[x + 1] < averageArray(A)))
        {
            Console.WriteLine($"1.2.Cреднее арифметическое {averageArray(A)} находится между {x}-м и {x + 1}-м элементом массива");
        }
    }
}
OkoloAverage(A);

int Blizko(int[] A)
{
    int position = 0;
    int min = Math.Abs(averageArray(A) - A[0]);
    for (int x = 0; x < A.Length; x++)
    {
        if (Math.Abs(averageArray(A) - A[x]) < min)
        {
            min = Math.Abs(averageArray(A) - A[x]);
            position = x;
        }
    }
    return A[position];
}

Console.WriteLine($"1.3. Элемент, наиболее близкий к {averageArray(A)} = {Blizko(A)}");
