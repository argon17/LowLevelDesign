namespace ParkingLot;

public class ParkingSpot(VehicleType vehicleType)
{
    public VehicleType VehicleType { get; init; } = vehicleType;
}