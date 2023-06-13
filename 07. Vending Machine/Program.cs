string input = "";
string productName = "";
double coin;
double sum = 0;

while ((input = Console.ReadLine()) != "Start")
{
    coin = double.Parse(input);

    switch (coin)
    {
        case 0.1:
        case 0.2:
        case 0.5:
        case 1:
        case 2:
            sum += coin;
            break;
        default:
            Console.WriteLine($"Cannot accept {coin}");
            break;
    }
}

double nutsPrice = 2.0;
double waterPrice = 0.7;
double crispsPrice = 1.5;
double sodaPrice = 0.8;
double cokePrice = 1.0;

while ((productName = Console.ReadLine()) != "End")
{
    switch (productName)
    {
        case "Nuts":
            if (sum >= nutsPrice)
            {
                Console.WriteLine($"Purchased {productName.ToLower()}");
                sum -= 2.0;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Water":
            if (sum >= waterPrice)
            {
                Console.WriteLine($"Purchased {productName.ToLower()}");
                sum -= 0.7;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Crisps":
            if (sum >= crispsPrice)
            {
                Console.WriteLine($"Purchased {productName.ToLower()}");
                sum -= 1.5;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Soda":
            if (sum >= sodaPrice)
            {
                Console.WriteLine($"Purchased {productName.ToLower()}");
                sum -= 0.8;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Coke":
            if (sum >= cokePrice)
            {
                Console.WriteLine($"Purchased {productName.ToLower()}");
                sum -= 1.0;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        default:
            Console.WriteLine("Invalid product");
            break;
    }
}

Console.WriteLine($"Change: {sum:F2}");