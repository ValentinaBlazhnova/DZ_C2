﻿/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());


string WeekDay(int day)
{
    if (day< 1 || day > 7)
    {
       return "Некорректная цифра дня недели";
    }

    if (day == 6 || day == 7)
    {
        return "Да";
    }
    else
    {
        return"Нет";
    }   
}
string result = WeekDay(day);
Console.WriteLine(result);