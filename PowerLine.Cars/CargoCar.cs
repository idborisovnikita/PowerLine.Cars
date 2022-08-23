namespace PowerLine.Cars;

public class CargoCar : Vehicle, ICargoCar {

    public CargoCar(IVehicleEngine engine, IVehicleProcessor processor, double maxFuelValue, double currentFuelValue, double maxLoad, double currentLoad)
        : base(engine, processor, maxFuelValue, currentFuelValue) {

        if (currentLoad > maxLoad) throw new ArgumentException("Value can't be greater than maxLoad", nameof(currentLoad));
        MaxLoad = maxLoad;
        CurrentLoad = currentLoad;
    }

    public override VehicleType VehicleType => VehicleType.CargoCar;
    public override double CurrentFuelConsumption => _engine.FuelConsumption / (100 - 4 * Math.Truncate(CurrentLoad / 200)) * 100;
    public double MaxLoad { get; private set; }
    public double CurrentLoad { get; set; }
}