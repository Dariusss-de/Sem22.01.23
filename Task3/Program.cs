// Задан список фамилий из N человек. Обменяйте местами фамилии брокеров: первого и последнего, второго и предпоследнего, третьего от начала и третьего от конца

void fillMass(String[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        array[i] = Console.ReadLine();
    }
}

void PrintMass(String[] array)
{
    foreach(String item in array)
    {
        Console.Write(item+" ");
    }
    Console.WriteLine();
}

void FindMaxNumber(String[]array)
{
    for(int i=0;i<array.Length;i++)
    Console.Write(array[array.Length - i - 1] + " ");
}
Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine()?? "");
String[] names = new String[N];
fillMass(names);
PrintMass(names);
FindMaxNumber(names);
