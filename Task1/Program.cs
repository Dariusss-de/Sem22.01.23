// Найти максимальное количество последовательных элементов
void fillMass(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        int num = new Random().Next(2);
        array[i] = num;
    }
}

void PrintMass(int[] array)
{
    foreach(int item in array)
    {
        Console.Write(item+" ");
    }
    Console.WriteLine();
}

int FindMaxNumber(int[]array)
{
    int result = 1;
    int count =1;
    for(int i=0;i<array.Length-1;i++)
    {
        if(array[i]==array[i+1] && array[i]==1) 
        {
        count++;
        if(count>result) result =count;
        }else count = 1;
    }
    return result;
}
Console.Write("Введите размер массива: ");
int raz = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[raz];
fillMass(arr);
PrintMass(arr);
Console.WriteLine(FindMaxNumber(arr));
