namespace PowerLine.Cars;

public class PassengerCar : Vehicle, IPassengerCar {

    public PassengerCar(IVehicleEngine engine, IVehicleProcessor processor, double maxFuelValue, double currentFuelValue, int maxPassengers, int currentPassengers)
        : base(engine, processor, maxFuelValue, currentFuelValue) {

        if (currentPassengers > maxPassengers) throw new ArgumentException("Value can't be greater than maxPassengers", nameof(currentPassengers));
        MaxPassengers = maxPassengers;
        CurrentPassengers = currentPassengers;
    }

    public override VehicleType VehicleType => VehicleType.PassengerCar;
    public override double CurrentFuelConsumption => _engine.FuelConsumption / (100 - 6 * CurrentPassengers) * 100;
    public int MaxPassengers { get; private set; }
    public int CurrentPassengers { get; set; }
}