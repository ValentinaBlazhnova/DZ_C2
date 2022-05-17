/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
Программа работает. Не хватает проверки на терхзначность.
Не смешивайте программу с функциями, иначе получается трудночитаемая каша.
Если строк будет больше 100, сами начнете путаться. Пусть функции будут перед программой или после.*/


Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// int number1 = number / 10;//
//int number2 = numberB % 10;//
//Console.WriteLine(number2);//   - код без функции

int SecondNumber(int number)
{
    int number2 = (number / 10) % 10;
    return number2;
}

int result = SecondNumber(number);
Console.WriteLine(result);
