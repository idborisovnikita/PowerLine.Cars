namespace PowerLine.Cars;

public class SportCar : Vehicle {

    public SportCar(IVehicleEngine engine, IVehicleProcessor processor, double maxFuelValue, double currentFuelValue)
        : base(engine, processor, maxFuelValue, currentFuelValue) { }

    public override VehicleType VehicleType => VehicleType.SportCar;
}