Console.Clear();
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// int Metod3() //не принимает никакие аргументы
// {
// return DateTime.Now.Year;
// }
// int year = Metod3();
// Console.WriteLine(year);

//Самая важная группа методов, это методы, которые что-то принимают и что-то возвращают.
// string Metod4(int count, string text)
// {
// int i = 0;
// string result = String.Empty;
// while (i<count)
// {
// result = result + text;
// i++;
// }
// return result;
// }
// // string res = Metod4(10, "asdf");
// // Console.WriteLine(res);
// string res = Metod4(10, "z ");
// Console.WriteLine(res);

// Далее та же программа но с использованием For.
// string Metod4(int count, string text)
// {
// string result = String.Empty;
// for (int i = 0; i<count; i++)
// {
// result = result + text;
// }
// return result;
// }
// string res = Metod4(10, "Привет! ");
// Console.WriteLine(res);


// string text ="— Я думаю, — сказал князь, улыбаясь, — что,
// "ежели бы вас послали вместо нашего милого Винценгероде,"
// "вы бы взяли приступом согласие прусского короля."
// "Вы так красноречивы. Вы дадите мне чаю?";
// string Replace(string text, char oldValue, char newValue)
// {
// string result = String.Empty;
// int length = text Length;
// for (int i = 0; i < length; i++)
// {
// if(text[i] == oldValue) 
// result = result + $"{NewValue}";
// else 
// result + result $"{text[i]}";
// }
// return result;
// }
// string newText = Replace(text, ' ' , '|');
// Console.WriteLine(newText);

// Определяет день недели указанной даты.
// DateTime someDate = new DateTime(2015, 03, 31);
// Console.WriteLine(someDate.DayOfWeek);

int[] arr = {3, 8, 3, 3, 1, 6, 5, 1, 7};
void PrintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
void SelectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
   int minPosition = i;
for (int j = i+1; j < array.Length; j++)
   {
     if(array[j] < array[minPosition]) 
     minPosition = j;
   }
int temporary = array[i];
array[i] = array[minPosition];
array[minPosition] = temporary;
}
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


