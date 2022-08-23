namespace PowerLine.Cars;

public class VehicleProcessor : IVehicleProcessor {

    public double CalculateRange(double fuelConsumption, double fuelValue) => fuelValue / fuelConsumption * 100;

    public double CalculateTimeToArrival(double distance, double speed, double fuelConsumption, out double fuelAmountRequired) {
        fuelAmountRequired = distance / 100 * fuelConsumption;
        return distance / speed;
    }
}