namespace ParkingLot.Test;

public class UnitTest1
{
    [Fact]
    public void TestParkingLotService()
    {
        ParkingLotService parkingLotService = ParkingLotService.Instance;

        ParkingSpot[] parkingSpots1 =
        [
            new(VehicleType.Car),
            new(VehicleType.Motorcycle),
        ];
        ParkingSpot[] parkingSpots2 =
        [
            new(VehicleType.Truck),
            new(VehicleType.Car)
        ];

        ParkingLevel parkingLevel1 = new(parkingSpots1);
        ParkingLevel parkingLevel2 = new(parkingSpots2);

        parkingLotService.AddParkingLevel(parkingLevel1);
        parkingLotService.AddParkingLevel(parkingLevel2);

        KeyValuePair<VehicleType, bool>[] incomingVehicles =
        [
            new(VehicleType.Truck, true),
            new(VehicleType.Motorcycle, true),
            new(VehicleType.Motorcycle, true),
            new(VehicleType.Motorcycle, false),
            new(VehicleType.Car, true),
            new(VehicleType.Motorcycle, true)
        ];

        List<bool> actualResults = [];
        foreach ((VehicleType vehicle, bool toPark) in incomingVehicles)
        {
            var result = toPark ? parkingLotService.ParkVehicle(vehicle) : parkingLotService.UnparkVehicle(vehicle);
            actualResults.Add(result);
        }

        bool[] expectedResults = [true, true, false, true, true, true];
        Assert.Equal(expectedResults, actualResults);
    }
}