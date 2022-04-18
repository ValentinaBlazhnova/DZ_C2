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