int n = int.Parse(Console.ReadLine());
int input = n;
int sum = 0;

while (n > 0)
{
    int number = n % 10;
    int fact = 1;

    for (int i = 1; i <= number; i++)
    {
        fact *= i;
    }

    sum += fact;
    n /= 10;
}

if (sum == input)
{
    Console.WriteLine($"yes");
}
else
{
    Console.WriteLine($"no");
}