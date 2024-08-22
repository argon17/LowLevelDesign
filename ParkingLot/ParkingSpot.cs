public class ParkingSpot
{
    public ParkingSpot(VehicleType vehicleType)
    {
        VehicleType = vehicleType;
    }
    public VehicleType VehicleType { get; init; }
}