/* 

Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */


Console.Write("Введите число A: ");
int tnA = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int tnB = int.Parse(Console.ReadLine());


int tnAA = tnA;
for (int i = 0; i < tnB - 1; i++)
{
    tnA = tnA * tnAA;
    //Console.WriteLine(tnA);
}

Console.Write("Натуральная степень = ");
Console.Write(tnA);