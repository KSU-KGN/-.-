// Программа из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3-м символам.
// Первоначальный массив можно ввести с клавиатуры, либо используется массив, заданный в программе.
// Выбор осуществляет пользователь.

string[] CreateNewArray(string[] array)
{
    int indexNew = 0;
    string[] newArray = new string[0];
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref newArray, indexNew+1);
            newArray[indexNew] = array[i];
            indexNew++;
        }
    }
    return newArray;
}

void WriteArray(string[] mass)
{
    int i;
    Console.Write("[");
    for (i = 0; i < mass.Length - 1; ++i)
    {
        Console.Write($"\"{mass[i]}\", ");
    }
    if (mass.Length > 0)
    {
        Console.Write($"\"{mass[i]}\"]");    
    }
    else
    {
        Console.Write("]");
    }
}

int index = 0, indexNew = 0;
string answer = "";
string[] array;

Console.WriteLine("Вы будете сами вводить массив строк?\n" + 
                  "Если нет, то будет использоваться имеющийся массив.");
do
{
    Console.Write("Введите Y или N: ");
    answer = Console.ReadLine().ToUpper();   
}              
while (String.Compare(answer, "Y") != 0 && String.Compare(answer, "N") != 0);
if (String.Compare(answer, "Y") == 0)
{
    Console.WriteLine("Введите массив строк, разделяя строки \",\"\n" +
                      "Например: 1234, 1567, -2, computer science");
    array = Console.ReadLine().Split(", ");
}
else
{
    array = new string[] {"hello", "2", "world", ":-)"};
}
WriteArray(array);
Console.Write(" -> ");

string[] newArray = CreateNewArray(array);
WriteArray(newArray);
if (newArray.Length == 0)
{
    Console.WriteLine("\nВ исходном массиве не было строк с длиной меньше либо равной 3-м символам");
}