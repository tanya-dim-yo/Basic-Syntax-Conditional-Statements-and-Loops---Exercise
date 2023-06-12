int countOfPeople = int.Parse(Console.ReadLine());
string groupType = Console.ReadLine();
string day = Console.ReadLine();
decimal totalSum = 0M;

if (groupType == "Students")
{
    if (day == "Friday")
    {
        totalSum = countOfPeople * 8.45M;
    }
    else if (day == "Saturday")
    {
        totalSum = countOfPeople * 9.80M;
    }
    else if (day == "Sunday")
    {
        totalSum = countOfPeople * 10.46M;
    }

    if (countOfPeople >= 30)
    {
        totalSum -= totalSum * 0.15M;
    }
}
else if (groupType == "Business")
{
    if (countOfPeople >= 100)
    {
        countOfPeople -= 10;
    }
    
    if (day == "Friday")
    {
        totalSum = countOfPeople * 10.90M;
    }
    else if (day == "Saturday")
    {
        totalSum = countOfPeople * 15.60M;
    }
    else if (day == "Sunday")
    {
        totalSum = countOfPeople * 16.0M;
    }
}
else if (groupType == "Regular")
{
    if (day == "Friday")
    {
        totalSum = countOfPeople * 15.0M;
    }
    else if (day == "Saturday")
    {
        totalSum = countOfPeople * 20.0M;
    }
    else if (day == "Sunday")
    {
        totalSum = countOfPeople * 22.50M;
    }

    if (countOfPeople >= 10 && countOfPeople <= 20)
    {
        totalSum -= totalSum * 0.05M;
    }
}

Console.WriteLine($"Total price: {totalSum:F2}");