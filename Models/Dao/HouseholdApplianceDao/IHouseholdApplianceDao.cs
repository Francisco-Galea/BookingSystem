using Boocking.Models.Entities.RentableEntities;

namespace Boocking.Models.Dao.HouseholdApplianceDao
{
    internal interface IHouseholdApplianceDao
    {
        void CreateHouseholdAppliance();
        void UpdateHouseholdAppliance(int HouseholdApplianceId, HouseholdApplianceEntity householdAppliance);
        HouseholdApplianceEntity GetHouseholdApplianceById(int HouseholdApplianceId);
        List<HouseholdApplianceEntity> GetAllHouseholdAppliances();
        void DeleteHouseholdAppliance(int HouseholdApplianceId);
    }
}
