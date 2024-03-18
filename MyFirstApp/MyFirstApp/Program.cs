// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double GetAverage(int[] numbers)
{
    var suma = 0;
    foreach (var number in numbers)
    {
        suma += number;
    }

    return (double) suma / numbers.Length;
}

int[] numbers = {1,2,3,4};
double average = GetAverage(numbers);
Console.WriteLine(average);

static int ZnajdzMaksymalnaWartosc(int[] tablica)
{
    if (tablica == null || tablica.Length == 0)
    {
        throw new ArgumentException("Tablica jest pusta lub null.");
    }

    int maks = tablica[0];
    for (int i = 1; i < tablica.Length; i++)
    {
        if (tablica[i] > maks)
        {
            maks = tablica[i];
        }
    }

    return maks;
}

int[] liczby = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 0 };
int maksymalnaWartosc = ZnajdzMaksymalnaWartosc(liczby);
Console.WriteLine($"Maksymalna wartość w tablicy to: {maksymalnaWartosc}");
