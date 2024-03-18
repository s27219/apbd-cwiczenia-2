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