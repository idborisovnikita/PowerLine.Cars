namespace PowerLine.Cars;

public abstract class Vehicle : IVehicle {
    protected Vehicle(IVehicleEngine engine, IVehicleProcessor processor, double maxFuelValue, double currentFuelValue) {
        _engine = engine;
        _processor = processor;
        MaxFuelValue = maxFuelValue;
        CurrentFuelValue = currentFuelValue;
    }

    public readonly IVehicleEngine _engine;
    public readonly IVehicleProcessor _processor;

    public abstract VehicleType VehicleType { get; }
    public double MaxFuelValue { get; private set; }
    public double CurrentFuelValue { get; private set; }
    public virtual double CurrentFuelConsumption => _engine.FuelConsumption;

    public double GetMaxRange() => _processor.CalculateRange(CurrentFuelConsumption, MaxFuelValue);
    public double GetCurrentRange() => _processor.CalculateRange(CurrentFuelConsumption, CurrentFuelValue);
    public (double, double) GetTimeToArrival(double distance) {
        var result = _processor.CalculateTimeToArrival(distance, _engine.Speed, CurrentFuelConsumption, out var fuelAmountRequired);
        return (result, fuelAmountRequired);
    }
}