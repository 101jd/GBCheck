// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.

using System.Runtime.Intrinsics.Arm;

int n = 0;
string input;
int size;
int maxLength = 3;

// Задаём размер массива и создаём массив строк
System.Console.WriteLine("Введите размер массива строк:");
do
{
    input = Console.ReadLine()!;
} while (!int.TryParse(input, out n) || int.Parse(input) <= 0);
size = int.Parse(input);
string[] strings = new string[size];

// Заполняем массив
for (int i = 0; i < strings.Length; i++)
{
    System.Console.Write("Введите строку: ");
    strings[i] = Console.ReadLine()!;
}

// Проверка длины строки
bool IsLess(string s)
{
    if (s.Length <= maxLength)
        return true;
    return false;
}

// Создаём новый массив
int count = 0;
for (int i = 0; i < strings.Length; i++)
{
    if (IsLess(strings[i]))
        count++;
}
string[] result = new string[count];

// Заполняем новый массив
int index = 0;
for (int i = 0; i < strings.Length; i++)
{
    if (IsLess(strings[i]))
    {
        result[index] = strings[i];
        index++;
    }
}

// Выводим результирующий массив
System.Console.WriteLine("\nRESULT:");
foreach (string e in result)
{
    System.Console.WriteLine(e);
}