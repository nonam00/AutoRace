namespace AutoRace.Cars;

public abstract class Car
{
    public int S { get; set; } = 0;
    protected int MinSpeed;
    protected int MaxSpeed;

    private Random rndSpeed = new Random();
    public virtual void Move(object sender, EventArgs e)
    {
        S += rndSpeed.Next(MinSpeed, MaxSpeed);
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        if (IsFinished())
            return "comleted the distance";
        else
            return $"completed {S / 10}% of the distance";
    }

    public bool IsFinished() => S >= 1000;
}
