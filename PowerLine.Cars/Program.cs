IVehicle[] vehicles = new IVehicle[] {
    new PassengerCar(
        new VehicleEngine {
            Speed = 110,
            FuelConsumption = 5
        },
        new VehicleProcessor(),
        70, 65, 4, 3),

    new CargoCar(
        new VehicleEngine {
            Speed = 90,
            FuelConsumption = 20
        },
        new VehicleProcessor(),
        200, 180, 4000, 3500)};

foreach (var vehicle in vehicles) {
    Console.WriteLine(vehicle.GetCurrentRange());
    Console.WriteLine(vehicle.GetMaxRange());
    var time = vehicle.GetTimeToArrival(1000);
    Console.WriteLine($"{time.Item1} Amount of fuel required: {time.Item2}");
    Console.WriteLine();
}
