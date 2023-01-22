// Найти наибольшее количество повторений числа
void fillMass(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        int num = new Random().Next(1,16);
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
    int result = 0;
    int count =0;
    for(int i=0;i<array.Length-1;i++)
    {
        count = 1;
        for(int j=i+1;j<array.Length;j++)
        if(array[i]==array[j])
        {
         count++;
        if(count>result) 
        result = count;
        }
    }
    return result;
}
Console.Write("Введите размер массива: ");
int raz = int.Parse(Console.ReadLine()?? "");
int[] arr = new int[raz];
fillMass(arr);
PrintMass(arr);
Console.WriteLine(FindMaxNumber(arr));

