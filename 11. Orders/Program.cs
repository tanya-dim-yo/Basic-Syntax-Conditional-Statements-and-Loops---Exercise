int ordersNumber = int.Parse(Console.ReadLine());
double totalSum = 0;

for (int i = 1; i <= ordersNumber; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int daysInMonth = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());

    double sum = (daysInMonth * capsulesCount) * pricePerCapsule;
    Console.WriteLine($"The price for the coffee is: ${sum:F2}");
    totalSum += sum;
}

Console.WriteLine($"Total: ${totalSum:F2}");