namespace ParkingLot;

public class ParkingLevel
{
    private readonly Dictionary<VehicleType, int> _freeSpots;

    public ParkingLevel(ParkingSpot[] parkingSpots)
    {
        _parkingSpots = [.. parkingSpots];
        _freeSpots = [];
        foreach (ParkingSpot parkingSpot in _parkingSpots)
        {
            _freeSpots.TryAdd(parkingSpot.VehicleType, 0);
            ++_freeSpots[parkingSpot.VehicleType];
        }
    }

    private readonly List<ParkingSpot> _parkingSpots;

    internal void AddParkingSpot(ParkingSpot newParkingSpot)
    {
        _parkingSpots.Add(newParkingSpot);
        ++_freeSpots[newParkingSpot.VehicleType];
    }

    internal bool ParkVehicle(VehicleType vehicleType)
    {
        if (_freeSpots.ContainsKey(vehicleType) && _freeSpots[vehicleType] > 0)
        {
            --_freeSpots[vehicleType];
            return true;
        }

        return false;
    }

    internal bool UnParkVehicle(VehicleType vehicleType)
    {
        if (_freeSpots.ContainsKey(vehicleType))
        {
            ++_freeSpots[vehicleType];
            return true;
        }

        return false;
    }
}