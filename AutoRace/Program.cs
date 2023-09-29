using AutoRace;
using AutoRace.Cars;

List<Car> cars = new List<Car>
{
    new SportCar(),
    new PassengerCar(),
    new FreightСar(),
    new Bus()
};
try
{
    Game game = new Game(cars);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}