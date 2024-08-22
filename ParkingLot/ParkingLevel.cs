public class ParkingLevel
{
    readonly Dictionary<VehicleType, int> freeSpots;
    public ParkingLevel(ParkingSpot[] parkingSpots)
    {
        _parkingSpots = [.. parkingSpots];
        freeSpots = [];
        foreach (ParkingSpot parkingSpot in _parkingSpots)
        {
            if (!freeSpots.ContainsKey(parkingSpot.VehicleType))
            {
                freeSpots[parkingSpot.VehicleType] = 0;
            }
            ++freeSpots[parkingSpot.VehicleType];
        }
    }
    public List<ParkingSpot> _parkingSpots;
    internal void AddParkingSpot(ParkingSpot newParkingSpot)
    {
        _parkingSpots.Add(newParkingSpot);
        ++freeSpots[newParkingSpot.VehicleType];
    }

    internal bool ParkVehicle(VehicleType vehicleType)
    {
        if (freeSpots.ContainsKey(vehicleType) && freeSpots[vehicleType] > 0)
        {
            --freeSpots[vehicleType];
            return true;
        }
        return false;
    }

    internal bool UnParkVehicle(VehicleType vehicleType)
    {
        if (freeSpots.ContainsKey(vehicleType))
        {
            ++freeSpots[vehicleType];
            return true;
        }
        return false;
    }
}