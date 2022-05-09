// See https://aka.ms/new-console-template for more information

const int max = 100; //макс длинна массива
double[] a = new double[max];  // объявление массива
int n = InputArray();  // количество элементов и ввод массива
OutputArray("До сортировки", n);  // вывод массива
BoobleSort(n);     // сортировка по убыванию
OutputArray("После пузырьковой сортировки", n);

//Метод ввода данных в массив
int InputArray()
{
    int n;
    Console.Write("Ввести кол-во чисел: ");
    n = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        Console.Write("a[{0}]=", i);
        a[i] = Convert.ToDouble(Console.ReadLine());
    }
    return n;
}
// Вывод введённого массива
void OutputArray(string z, int n)
{
    Console.WriteLine(z);
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0:#.#}    ",a[i]);
    }
    Console.WriteLine();
}

// Пузырьковая сортировка по убыванию
void BoobleSort(int n)
{
    double c;
    for (int i = n - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (a[j] < a[j + 1])
            {
                c = a[j];
                a[j] = a[j + 1];
                a[j + 1] = c;
            }
        }
    }
}