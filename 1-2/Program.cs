//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("This programm which help you compare two numbers. Enjoy");

Console.WriteLine("Enter first number ");
int a  = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine("Enter second number ");
int b  = Convert.ToInt32(Console.ReadLine());;

if(a>b)
{ 
    Console.WriteLine($"{a} is max number,{b} is min number");
}
if(a<b)
{ 
    Console.WriteLine($"{a} is min number,{b} is max number");
}
else
{ 
    Console.Write("This numbers is equal");
}



Console.Read();