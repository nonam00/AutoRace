namespace AutoRace.Cars;
public class Game
{
    private static int S = 1000;
    private EventHandler<EventArgs>? handler;
    public Game(List<Car>? cars)
    {
        if (cars.Count == 0)
            throw new ArgumentException("Список участников пуст");
        for (int i = 0; i < cars.Count; i++)
        {
            handler += cars[i].Move;
        }

        int j = 1;
        while (true)
        {
            Console.WriteLine(j++);
            handler(this, new EventArgs());
            if (End(cars))
                break;
            Thread.Sleep(1500);
            Console.Clear();
        }
    }

    private bool End(List<Car> cars)
    {
        for (int i = 0; i < cars.Count; i++)
        {
            if (cars[i].IsFinished())
            {
                return true;
            }
        }
        return false;
    }
}
