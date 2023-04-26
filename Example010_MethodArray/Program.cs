int[] array = {1,22,23,4,18,65,36,27,18};
int n = array.Length;
Console.WriteLine(n);
int find = 18;

int index = 0;

while (index < n)
{

    if(array[index] == find) //индекс числа из массива совпадает с числом 4
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}


