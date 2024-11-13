using Booking.Models.Dao.ConnectionString;
using Booking.Models.Entities;

namespace Boocking.Models.Dao.HouseholdApplianceDao
{
    public class HouseholdApplianceDaoSQLSERVER : IHouseholdApplianceDao
    {
        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void CreateHouseholdAppliance()
        {
            throw new NotImplementedException();
        }

        public void DeleteHouseholdAppliance(int HouseholdApplianceId)
        {
            throw new NotImplementedException();
        }

        public List<HouseholdApplianceEntity> GetAllHouseholdAppliances()
        {
            throw new NotImplementedException();
        }

        public HouseholdApplianceEntity GetHouseholdApplianceById(int HouseholdApplianceId)
        {
            throw new NotImplementedException();
        }

        public void UpdateHouseholdAppliance(int HouseholdApplianceId, HouseholdApplianceEntity householdAppliance)
        {
            throw new NotImplementedException();
        }
    }
}
