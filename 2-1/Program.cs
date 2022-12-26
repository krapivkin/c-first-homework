// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("This Program displays second digi of three-digit number. Enjoy.");
int number = 0;

while (number.ToString().Length < 3 || number.ToString().Length > 3)
{
    Console.WriteLine("Enter three-digit number:  ");
    try
    {
        number= Math.Abs(Convert.ToInt32(Console.ReadLine()));
    }
    catch (System.FormatException)
    