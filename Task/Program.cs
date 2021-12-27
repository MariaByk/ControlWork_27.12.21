void Array(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    int index = 0;
    for (index = 0;index < length;index++)
    {
        collection[index] = new Random().Next(1,10);       
        if (collection[index] % 2 == 0) i++;
    }
    PrintArray(collection);
    Console.WriteLine();
    int[] newArray = new int[i];
    index = 0;
    int ind = 0;
    while (index < length)
    {
        if (collection[index] % 2 == 0)
        {
            newArray[ind] = collection[index];
            ind++;
          
        }
        index++;
    }
 PrintArray(newArray);   
}

void PrintArray(int[] col)
{
    int count = col.Length;
    
    for (int position = 0; position < count;position++)
    {
        Console.WriteLine(col[position]);
    }
}


int[] array = new int[6];
Array(array);

