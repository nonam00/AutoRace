namespace AutoRace.Cars;
public class FreightСar : Car
{
    public FreightСar()
    {
        MinSpeed = 30; MaxSpeed = 60;
    }
    public override string ToString() =>
        $"Freight Car " + base.ToString();
}
