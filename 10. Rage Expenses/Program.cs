int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int trashedHeadsetNumber = 0;
int trashedMouseNumber = 0;
int trashedKeyboardNumber = 0;
int trashedDisplayNumber = 0;

for (int i = 1; i <= lostGames; i++)
{
    if (i % 2 == 0)
    {
        trashedHeadsetNumber++;
    }

    if (i % 3 == 0)
    {
        trashedMouseNumber++;
    }

    if (i % 2 == 0 && i % 3 == 0)
    {
        trashedKeyboardNumber++;
    }
}

trashedDisplayNumber = trashedKeyboardNumber / 2;
double totalSum = (trashedHeadsetNumber * headsetPrice) + (trashedMouseNumber * mousePrice) + (trashedKeyboardNumber * keyboardPrice) + (trashedDisplayNumber * displayPrice);
Console.WriteLine($"Rage expenses: {totalSum:F2} lv.");