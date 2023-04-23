/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

int [] Read()
{
string numstring;
System.Console.WriteLine("Введите числа через запятую");
numstring = Console.ReadLine();
string [] arraystring = numstring.Split(", ");
int [] array = new int [arraystring.Length];
for (int i = 0; i < arraystring.Length; i++)
{
    array[i] = int.Parse(arraystring[i]);
}
return array;
System.Console.WriteLine(string.Join("; ", array));
}

/*void Print(int [] array)
{
    System.Console.WriteLine(string.Join("; ", array));
}

Print(Read());*/

int PositiveNum(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
int count = PositiveNum(Read());
System.Console.WriteLine(count);


