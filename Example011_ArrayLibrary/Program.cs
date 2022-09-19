void FillArray(int[] collection) // наименование метода, в скобках аргумент.
{
    int length = collection.Length; // получаем длину нашего массива.
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10); //в ячейку коллекшн индекс 
        //кладем рандомное целое число от 1 до10.
        index++;
    }
} 
void PrintArray(int[]col)
{
    int count = col.Length; //обозначили количество элементов
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10]; //в массиве 10 элементов
FillArray(array);
PrintArray(array);