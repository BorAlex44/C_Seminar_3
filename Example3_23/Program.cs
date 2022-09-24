using static System.Console;
Clear();
WriteLine("Введите любое число: ");
int number = Convert.ToInt32(ReadLine());
int count = 1;
while (count <= number)
{
    Write($"{Math.Pow(count, 3)} ");
    count++;
}