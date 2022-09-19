int Max(int arg1, int arg2, int arg3) // описали значения функции
{
int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result; // возвращение результата функции
}
int[] array = { 45, 4, 76, 78, 555, 34, 32, 21, 77 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);