namespace PowerLine.Cars;

public class VehicleEngine : IVehicleEngine {

    /// <summary>
    /// Расход в литрах на 100км
    /// </summary>
    public double FuelConsumption { get; set; }

    public double Speed { get; set; }
}