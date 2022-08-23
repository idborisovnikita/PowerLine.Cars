namespace PowerLine.Cars.Tests;

public class VehicleProcessor {

    [Fact]
    public void Can_Calculate_PassengerCar() {
        //arange
        IVehicle testcar = new PassengerCar(
            new VehicleEngine { Speed = 100, FuelConsumption = 10 },
            new Cars.VehicleProcessor(),
            100, 50, 4, 1);

        //act
        var maxRange = testcar.GetMaxRange();
        var currentRage = testcar.GetCurrentRange();
        var timetoarrival = testcar.GetTimeToArrival(1000).Item1;

        //assert
        Assert.Equal(940, maxRange);
        Assert.Equal(470, currentRage);
        Assert.Equal(10, timetoarrival);
    }

    [Fact]
    public void Can_Calculate_CargoCar() {
        //arange
        IVehicle testcar = new CargoCar(
            new VehicleEngine { Speed = 100, FuelConsumption = 10 },
            new Cars.VehicleProcessor(),
            200, 100, 2000, 1000);

        //act
        var maxRange = testcar.GetMaxRange();
        var currentRage = testcar.GetCurrentRange();
        var timetoarrival = testcar.GetTimeToArrival(1000).Item1;

        //assert
        Assert.Equal(1600, maxRange);
        Assert.Equal(800, currentRage);
        Assert.Equal(10, timetoarrival);
    }
}