using static System.Console;
Clear();
WriteLine("Введите любое пятизначное число: ");
int number = int.Parse(ReadLine()!);
if (((number / 1000) / 10 == (number % 100) % 10) && ((number / 1000) % 10 == (number % 100) / 10))
{
    WriteLine($"Число {number} является палиндромом");
}
else
{
    WriteLine($"Число {number} не является палиндромом");
}
