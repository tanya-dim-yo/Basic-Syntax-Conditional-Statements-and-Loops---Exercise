int number = int.Parse(Console.ReadLine());
int divisibleMax = 0;

if (number % 10 == 0)
{
    divisibleMax = 10;
}
else if (number % 7 == 0)
{
    divisibleMax = 7;
}
else if (number % 6 == 0)
{
    divisibleMax = 6;
}
else if (number % 3 == 0)
{
    divisibleMax = 3;
}
else if (number % 2 == 0)
{
    divisibleMax = 2;
}

if (divisibleMax != 0)
{
    Console.WriteLine($"The number is divisible by {divisibleMax}");
}
else
{
    Console.WriteLine($"Not divisible");
}