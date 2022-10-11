


/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */


Console.Write("Введите длинну массива = ");
int klk = int.Parse(Console.ReadLine());

int[] a1 = new int[klk];
//int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8 };

for (int i = 0; i < a1.Length; i++)
{
    Console.Write("Введите число ");
    Console.Write(i + 1);
    Console.Write(" ");
    Console.WriteLine();
    a1[i] = int.Parse(Console.ReadLine());
}

printarray(a1);




void printarray(int[] array)
{
    Console.Write("Массив = ");
    Console.Write("[");
    for (int i = 0; i < a1.Length; i++)
    {
        Console.Write(a1[i]);
        if (i < a1.Length - 1) { Console.Write(", "); }
    }
    Console.Write("]");
}
