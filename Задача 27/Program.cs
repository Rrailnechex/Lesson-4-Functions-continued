

/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */


int[] IntArray(int num)
{
    List<int> tempList = new List<int>();
    while (num > 0)
    {
        tempList.Add(num % 10);
        num = num / 10;
    }
    tempList.Reverse();
    return tempList.ToArray();
}

int DigitsSumm(int[] inpArray)
{
    int tmp = 0;
    for (int i = 0; i < inpArray.Length; i++)
    {
        tmp += inpArray[i];
        //Console.WriteLine(inpArray[i]);
        //Console.WriteLine(tmp);
    }
    return tmp;
}

void DoLine()
{
    Console.WriteLine("-----------------------------");
}




Console.Write("Введите число: ");
int r1 = int.Parse(Console.ReadLine());

int[] g4g = IntArray(r1);
DoLine();
int hhh = DigitsSumm(g4g);
//DoLine();

Console.Write("Сумма цифр в числе = ");
Console.Write(hhh);
