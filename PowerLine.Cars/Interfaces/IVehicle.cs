namespace PowerLine.Cars.Interfaces;

public interface IVehicle {
    double MaxFuelValue { get; }
    double CurrentFuelValue { get; }
    double GetMaxRange();
    double GetCurrentRange(); 
    (double, double) GetTimeToArrival(double distance);
}
