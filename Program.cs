//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int ReadInt (string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32 (Console.ReadLine());
    return value;
}

bool Validate3sing (int number)
{
    if (number >= 100)
    {
        return true;
    }

    System.Console.WriteLine("третьей цифры нет");
    return  false;
}

int num  = ReadInt("Введите число >> ");
if (Validate3sing(num))
{
    string NumberText = Convert.ToString(num);
    Console.WriteLine("третья цифра >> " + NumberText[2]);
}
