namespace AutoRace.Cars;

public class PassengerCar : Car
{
    public PassengerCar()
    {
        MinSpeed = 60; MaxSpeed = 100;
    }
    public override string ToString() =>
        $"Passenger Car " + base.ToString();
}
