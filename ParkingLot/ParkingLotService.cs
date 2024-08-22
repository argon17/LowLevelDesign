public class ParkingLotSerive
{
    private static ParkingLotSerive? _instance;
    private ParkingLotSerive()
    {
        parkingLevels = [];
    }
    public static ParkingLotSerive Instance => _instance ??= new ParkingLotSerive();

    private readonly List<ParkingLevel> parkingLevels;
    public void AddParkingLevel(ParkingLevel parkingLevel) => parkingLevels.Add(parkingLevel);
    public bool ParkVehicle(VehicleType vehicleType)
    {
        foreach (ParkingLevel parkingLevel in parkingLevels)
        {
            if (parkingLevel.ParkVehicle(vehicleType))
            {
                return true;
            }
        }
        return false;
    }
    public bool UnparkVehicle(VehicleType vehicleType){
        foreach (ParkingLevel parkingLevel in parkingLevels)
        {
            if (parkingLevel.UnParkVehicle(vehicleType))
            {
                return true;
            }
        }
        return false;
    } 
}