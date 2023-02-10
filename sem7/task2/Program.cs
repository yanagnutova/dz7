//Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4          //1, 7 -> такого числа в массиве нет   //1, 1 - > 1

int[,] CreateNumbersArray()
{
    Random rnd = new Random ();
    int[,] array = new int[3,4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = rnd.Next(0, 10);
        }
    }
    return array;
}
    
void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int Position (string msg)
{
    Console.WriteLine (msg + " ");
    return Convert.ToInt32 (Console.ReadLine());
}

int[,] array = CreateNumbersArray();
PrintArray (array);
int lineX = Position ("Введите номер строки");
int columnY = Position ("Введите номер столбца");

if (lineX > array.GetLength(0) || lineX < 1 || columnY > array.GetLength(1) || columnY < 1)
{
    Console.WriteLine ("Ошибка! Такого элемента в массиве нет");
} 
else 
{
    Console.WriteLine ($"Элемент массива = {array[lineX - 1, columnY - 1]}");
}
