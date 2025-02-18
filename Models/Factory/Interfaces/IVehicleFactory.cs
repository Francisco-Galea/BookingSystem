using Boocking.Models.Entities.RentableEntities;

namespace Boocking.Models.Factory.Interfaces
{
    public interface IVehicleFactory
    {
        VehicleEntity CreateVehicleEntity(string NAME, string DESCRIPTION, decimal COSTUSAGEPERDAY, string BRAND, string MODEL, int PASSENGERCAPACITY, string SERIALNUMBER);
    }
}
