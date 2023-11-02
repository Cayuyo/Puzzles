// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("********** Matriz Aleatoria **********");
int[] randomNumbers = RandomArray();

string formattedList = "Lista de números: {" + string.Join(", ", randomNumbers) + "}";
Console.WriteLine(formattedList);

Console.WriteLine();

int minValue = int.MaxValue;
int maxValue = int.MinValue;

foreach (int number in randomNumbers)
{
    if (number < minValue)
    {
        minValue = number;
    }
    if (number > maxValue)
    {
        maxValue = number;
    }
}
Console.WriteLine("Valor mínimo: {0}", minValue);
Console.WriteLine("Valor máximo: {0}", maxValue);

int sum = 0;
foreach (int number in randomNumbers)
{
    sum += number;
}

Console.WriteLine("Suma de todos los valores: {0}", sum);

static int[] RandomArray()
{
    Random random = new();
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(5, 26);
    }

    return array;
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("********** Lanzamiento de Moneda **********");

static string TossCoin()
{
    Console.WriteLine("Lanzando una moneda!");

    Random random = new Random();
    int randomNumber = random.Next(2);
    if (randomNumber == 0)
    {
        return "Cara";
    }
    else
    {
        return "Cruz"; // Dato: En Chile se le conoce como "Sello".
    }
}

static double TossMultipleCoins(int num)
{
    int headsCount = 0;

    for (int i = 0; i < num; i++)
    {
        string result = TossCoin();
        if (result == "Cara")
        {
            headsCount++;
        }
    }

    double ratio = (double)headsCount / num;
    return ratio;
}

string result = TossCoin();
Console.WriteLine("Resultado: {0}", result);
Console.WriteLine();

Console.WriteLine("*****[ TossMultipleCoins(int num) ]*****");
int num = 15;
double ratio = TossMultipleCoins(num);
Console.WriteLine("Relación entre caras y lanzamientos: " + ratio);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("********** Nombres **********");

static List<string> Nombres()
{
    List<string> names = new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };
    List<string> filteredNames = new List<string>();

    foreach (string name in names)
    {
        if (name.Length > 5)
        {
            filteredNames.Add(name);
        }
    }

    return filteredNames;
}

static List<T> ShuffleList<T>(List<T> list)
{
    Random random = new Random();
    List<T> shuffledList = new List<T>(list);
    int n = shuffledList.Count;

    while (n > 1)
    {
        n--;
        int k = random.Next(n + 1);
        T value = shuffledList[k];
        shuffledList[k] = shuffledList[n];
        shuffledList[n] = value;
    }

    return shuffledList;
}

List<string> names = Nombres();
Console.WriteLine("Nombres con más de 5 caracteres:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine();
Console.WriteLine("Nombres barajados:");
List<string> shuffledNames = ShuffleList(names);
foreach (string name in shuffledNames)
{
    Console.WriteLine(name);
}