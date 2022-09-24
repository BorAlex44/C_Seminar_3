using static System.Console;
Clear();
WriteLine("Введите любое пятизначное число: ");
int number = int.Parse(ReadLine()!);
int temp1 = number / 1000;
int temp2 = number % 100;
if ((temp1 / 10 == temp2 % 10) && (temp1 % 10 == temp2 / 10))
{
    WriteLine($"Число {number} является палиндромом");
}
else
{
    WriteLine($"Число {number} не является палиндромом");
}