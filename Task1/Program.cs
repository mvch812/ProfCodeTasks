// задается число n
// количество натуральных чисел < n
// задается k и l


Console.WriteLine("ЗАДАЧА 1");
Console.WriteLine("Подсчитать количество натуральных чисел, не превосходящих заданного числа n, которые");
Console.WriteLine("1.1. делятся на k, но не на l");
Console.WriteLine("1.2. делятся хотябы на k или на l");
Console.WriteLine("1.3. не делятся на (k + l)");

Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число k:");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число l:");
int l = Convert.ToInt32(Console.ReadLine());


void FillArray(int[] Collection) // Метод, заполняющий массив натуральными числами
{
    int length = Collection.Length;
    int index = 0;
    int numberArray = 1;
    while (index < length)
    {
        Collection[index] = numberArray;
        Console.Write($"{Collection[index]} ");
        index++;
        numberArray++;
    }
}
int[] Collection = new int[n];
Console.WriteLine("Натуральные числа, не превышающие n:");
FillArray(Collection);

int index = 0;
int countK = 0;
int countL = 0;
int countKneL = 0;
int cooutNeKL = 0;
int m = k + l;

while (index < Collection.Length)
{
    if (Collection[index] % k == 0)
    {
        countK++;
        if (Collection[index] % l != 0)
        {
            countKneL++;
            if (Collection[index] % m != 0)
            {
                cooutNeKL++;
            }
        }
        else
        {
            if (Collection[index] % m != 0)
            {
                cooutNeKL++;
            }
        }
    }

    else
    {
        if (Collection[index] % l == 0)
        {
            countL++;
            if (Collection[index] % m != 0)
            {
                cooutNeKL++;
            }
        }
        else
        {
            if (Collection[index] % m != 0)
            {
                cooutNeKL++;
            }

        }
    }

    index++;

}
Console.WriteLine();
Console.WriteLine("Ответ на п.1.1.:");
Console.WriteLine(countKneL);
Console.WriteLine("Ответ на п.1.2.:");
Console.WriteLine(countL + countK);
Console.WriteLine("Ответ на п.1.3.:");
Console.WriteLine(cooutNeKL);
