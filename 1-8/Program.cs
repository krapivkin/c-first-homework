//Напишите программу, которая на вход принимает число (N),а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("This Program displays all even numbers up to your number. Enjoy.");
Console.WriteLine("Enter a positive integer: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int a = 1;

while (a <= number)
    if (a%2 == 0)
    
    {
        Console.WriteLine($"{a}; ");
        a++;
    }
    else
     a++;