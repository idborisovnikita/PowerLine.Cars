namespace PowerLine.Cars.Interfaces;
public interface IVehicleProcessor {
    double CalculateRange(double fuelConsumption, double fuelValue);
    double CalculateTimeToArrival(double distance, double speed, double fuelConsumption, out double fuelAmountRequired);
}
