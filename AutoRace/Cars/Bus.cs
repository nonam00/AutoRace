namespace AutoRace.Cars;
public class Bus : Car
{
    public Bus()
    {
        MinSpeed = 40; MaxSpeed = 80;
    }
    public override string ToString() =>
        "Bus " + base.ToString();
}
