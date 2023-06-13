float moneyProvided = float.Parse(Console.ReadLine());
float studentsNumber = float.Parse(Console.ReadLine());
float lightsaberPrice = float.Parse(Console.ReadLine());
float robePrice = float.Parse(Console.ReadLine());
float beltPrice = float.Parse(Console.ReadLine());

float lightsabersSum = lightsaberPrice * (int)Math.Ceiling(studentsNumber + studentsNumber * 0.1);
float robesSum = robePrice * studentsNumber;
float beltSum = beltPrice * (int)Math.Ceiling(studentsNumber - (studentsNumber / 6));

float totalSum = lightsabersSum + robesSum + beltSum;

if (totalSum <= moneyProvided)
{
    Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
}
else
{
    Console.WriteLine($"John will need {totalSum - moneyProvided:F2}lv more.");
}