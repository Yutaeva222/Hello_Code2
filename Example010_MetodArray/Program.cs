int [] array = {11,24,28,8,57,60,67,8};
int n = array.Length;
int find = 8;

int index = 0;
while(index <n)
{
    if(array[index] == find)
    {
    Console.WriteLine(index);
    break; // прервать проверку
    }
    index++;
}
