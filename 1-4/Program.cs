// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
  Console.WriteLine("This programm which help you search maximum  numbers of three. Enjoy");
  Console.WriteLine("Enter three numbers");
string[] array = Console.ReadLine().Split();
int a = int.Parse(array[0]);
int b = int.Parse(array[1]);
int c = int.Parse(array[2]);
int max = a;

if (a>b&&a>c)
{  
   Console.WriteLine($"{max} is max number");
}
else if (b>c&&b>a)
{
    max = b;Console.WriteLine($"{max} is max number");
}
else if (c>b&&c>a)
{
    max = c;Console.WriteLine($"{max} is max number");
}
 else 
{
    Console.Write("all numbers is equal");
}


Console.Read();