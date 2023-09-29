using AutoRace.Cars;

namespace AutoRace;

public class SportCar : Car
{
    public SportCar()
    {
        MinSpeed = 100; MaxSpeed = 150;
    }

    public override string ToString() =>
        $"Sport Car " + base.ToString();
}
