Console.Write("Your parked car model: ");
string carModel = Console.ReadLine();

Console.Write("Your parked car plate number: ");
string carPlateNumber = Console.ReadLine();

Console.Write("Hours car was parked: ");
int hours = int.Parse(Console.ReadLine());

double fee = calc(hours);

Console.WriteLine($"Your parked car model: {carModel}");
Console.WriteLine($"Your parked car plate number: {carPlateNumber}");
Console.WriteLine($"Your parked car fee is NGN {fee}");

static double calc(int hours)
{
    const double hourRate = 500.00;
    const double newHourRate = 100.00;

    if (hours <= 0)
    {
        return 0.00; 
    }
    else if (hours == 1)
    {
        return hourRate; 
    }
    else
    {
        return hourRate + (newHourRate * (hours - 1));
    }
}
