// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("This programm will help you to indicate the number is even or odd.Enjoy");

Console.WriteLine ("Enter  number : ");

int num = Convert.ToInt32(Console.ReadLine());

     if (num % 2 == 0)
    {
        Console.WriteLine($"{num} is EVEN number");
    }
    else
    
        Console.WriteLine($"{num} is ODD number");
    
    
