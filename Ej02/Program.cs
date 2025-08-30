class Engine
{
    public void Start() => Console.WriteLine("Engine started");
}

class Lights
{
    public void TurnOn() => Console.WriteLine("Lights turned on");
}

class CarFacade
{
    private Engine Engine = new Engine();
    private Lights Lights = new Lights();

    public void StartCar()
    {
        Engine.Start();
        Lights.TurnOn();
        Console.WriteLine("Car is ready to go!");
    }
}



class Program
{
    static void Main()
    {
        var Car = new CarFacade();
        Car.StartCar();
    }
}