namespace ParkingLot.Test;

public class UnitTest1
{
    [Fact]
    public void TestParkingLotService()
    {
        ParkingLotSerive parkingLotService = ParkingLotSerive.Instance;

        ParkingSpot[] parkingSpots1 = [
            new ParkingSpot(VehicleType.Car),
            new ParkingSpot(VehicleType.Motorcycle),
        ];
        ParkingSpot[] parkingSpots2 = [
            new ParkingSpot(VehicleType.Truck),
            new ParkingSpot(VehicleType.Car)
        ];

        ParkingLevel parkingLevel1 = new(parkingSpots1);
        ParkingLevel parkingLevel2 = new(parkingSpots2);

        parkingLotService.AddParkingLevel(parkingLevel1);
        parkingLotService.AddParkingLevel(parkingLevel2);

        KeyValuePair<VehicleType, bool>[] incomingVehicles =
        {
            new(VehicleType.Truck,true),
            new(VehicleType.Motorcycle,true),
            new(VehicleType.Motorcycle,true),
            new(VehicleType.Motorcycle,false),
            new(VehicleType.Car,true),
            new(VehicleType.Motorcycle,true),
        };

        List<bool> actualResults = [];
        foreach ((VehicleType vehicle, bool toPark) in incomingVehicles)
        {
            bool result;
            if (toPark)
                result = parkingLotService.ParkVehicle(vehicle);
            else
                result = parkingLotService.UnparkVehicle(vehicle);
            actualResults.Add(result);
        }

        bool[] expectedResults = [true, true, false, true, true, true];
        Assert.Equal(expectedResults, actualResults);
    }
}