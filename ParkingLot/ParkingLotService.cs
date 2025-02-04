namespace ParkingLot;

public class ParkingLotService
{
    private static ParkingLotService? _instance;

    private ParkingLotService()
    {
        _parkingLevels = [];
    }

    public static ParkingLotService Instance => _instance ??= new ParkingLotService();

    private readonly List<ParkingLevel> _parkingLevels;
    public void AddParkingLevel(ParkingLevel parkingLevel) => _parkingLevels.Add(parkingLevel);

    public bool ParkVehicle(VehicleType vehicleType)
    {
        foreach (ParkingLevel parkingLevel in _parkingLevels)
        {
            if (parkingLevel.ParkVehicle(vehicleType))
            {
                return true;
            }
        }

        return false;
    }

    public bool UnparkVehicle(VehicleType vehicleType)
    {
        foreach (ParkingLevel parkingLevel in _parkingLevels)
        {
            if (parkingLevel.UnParkVehicle(vehicleType))
            {
                return true;
            }
        }

        return false;
    }
}