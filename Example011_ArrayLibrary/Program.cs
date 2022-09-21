void FillArray(int[] collection)  //программа заполняет рандомными числами массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int dlina = col.Length;
    int schet = 0;
    while (schet < dlina)
    {
        Console.Write(col[schet]);
        schet++;
    }
}

int IndexOf(int[] massive, int find)
{
    int long1 = massive.Length;
    int num = 0;
    int answer = 0;
    while (num < long1)
    {
        if (massive[num] == find)
        {
            answer = num;
            break;
        }
        num++;
    }
    return answer;
}




int[] array = new int[10];
FillArray(array);
array[4] = 4;
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);